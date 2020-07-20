using Newtonsoft.Json;
using OBS.WebSocket.NET;
using OBS.WebSocket.NET.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBSShureLink
{
    public partial class frmMain : Form
    {
        protected ObsWebSocket _obs;
        protected object SceneMapping;
        protected Dictionary<string, int> mappings = new Dictionary<string, int>();

        public frmMain()
        {
            InitializeComponent();
            _obs = new ObsWebSocket();

            _obs.Connected += onConnect;
            _obs.Disconnected += onDisconnect;

            _obs.SceneChanged += onSceneChange;
            //_obs.SceneCollectionChanged += onSceneColChange;
            //_obs.ProfileChanged += onProfileChange;
            //_obs.TransitionChanged += onTransitionChange;
            //_obs.TransitionDurationChanged += onTransitionDurationChange;

            _obs.StreamingStateChanged += onStreamingStateChange;
            _obs.RecordingStateChanged += onRecordingStateChange;


            //_obs.StreamStatus += onStreamData;
        }

        private void sendShureMessage(string message)
        {

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                try
                {
                    //---create a TCPClient object at the IP and port no.---
                    TcpClient client = new TcpClient();
                    if (!client.ConnectAsync(Properties.Settings.Default.MicroflexHost, 2202).Wait(5000))
                    {
                        throw new Exception("Connection Timeout");
                    }
                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(message);

                    //---send the text---
                    Console.WriteLine("Sending : " + message);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                    //---read back the text---
                    byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                    int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                    string response = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                    Console.WriteLine("Received : " + response);
                    client.Close();
                    picMicroflexStatus.BackColor = Color.Lime;

                    if (response.Contains("< REP LED_COLOR_UNMUTED"))
                    {
                        string currentColour = response.Substring(24, (response.Length - 26));
                        BeginInvoke((MethodInvoker)delegate
                        {
                            lblCurrentColour.Text = currentColour;
                        });
                    }
                }
                catch (Exception e)
                {
                    picMicroflexStatus.BackColor = Color.Red;
                    Console.WriteLine("SocketException: {0}", e.Message);
                }
            }).Start();
        }

        private void onConnect(object sender, EventArgs e)
        {
            Console.WriteLine("OBS Websocket Connected");
            picWebsocketStatus.BackColor = Color.Lime;
            var scenes = _obs.Api.GetSceneList().Scenes;
            var currentScene = _obs.Api.GetCurrentScene().Name;
            foreach (var scene in scenes)
            {
                lstSources.Items.Add(scene.Name);
            }
            onSceneChange((ObsWebSocket)sender, _obs.Api.GetCurrentScene().Name);
            chkStreaming.Checked = _obs.Api.GetStreamingStatus().IsStreaming;
            chkRecording.Checked = _obs.Api.GetStreamingStatus().IsRecording;
            if (chkRecording.Checked || chkStreaming.Checked)
            {
                sendShureMessage("< SET LED_BRIGHTNESS 5 >");
            }
            else
            {
                sendShureMessage("< SET LED_BRIGHTNESS 0 >");
            }
        }

        private void onDisconnect(object sender, EventArgs e)
        {
            Console.WriteLine("OBS Websocket Disconnected");
            BeginInvoke((MethodInvoker)delegate
            {
                picWebsocketStatus.BackColor = Color.Red;
                lstSources.Items.Clear();
            });
            
        }

        private void onSceneChange(ObsWebSocket sender, string newSceneName)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                lblCurrentScene.Text = newSceneName;
            });
            if (!mappings.ContainsKey(newSceneName))
            {
                mappings[newSceneName] = 0;
            }
            sendShureMessage("< SET LED_COLOR_UNMUTED " + cmboColours.Items[mappings[newSceneName]] + " >");
        }

        private void onStreamingStateChange(ObsWebSocket sender, OutputState newState)
        {
            string state = "";
            switch (newState)
            {
                case OutputState.Starting:
                    state = "Stream starting...";
                    break;

                case OutputState.Started:
                    state = "Stream Started";
                    sendShureMessage("< SET LED_BRIGHTNESS 5 >");
                    BeginInvoke((MethodInvoker)delegate
                    {
                        chkStreaming.Checked = true;
                    });
                    break;

                case OutputState.Stopping:
                    state = "Stream stopping...";
                    break;

                case OutputState.Stopped:
                    state = "Stream Stopped";
                    sendShureMessage("< SET LED_BRIGHTNESS 0 >");
                    BeginInvoke((MethodInvoker)delegate
                    {
                        chkStreaming.Checked = false;
                    });
                    break;

                default:
                    state = "State unknown";
                    break;
            }
            Console.WriteLine(state);
        }

        private void onRecordingStateChange(ObsWebSocket sender, OutputState newState)
        {
            string state = "";
            switch (newState)
            {
                case OutputState.Starting:
                    state = "Recording starting...";
                    break;

                case OutputState.Started:
                    state = "Recording Started";
                    sendShureMessage("< SET LED_BRIGHTNESS 5 >");
                    BeginInvoke((MethodInvoker)delegate
                    {
                        chkRecording.Checked = true;
                    });
                    break;

                case OutputState.Stopping:
                    state = "Recording stopping...";
                    break;

                case OutputState.Stopped:
                    state = "Recording Stopped";
                    sendShureMessage("< SET LED_BRIGHTNESS 0 >");
                    BeginInvoke((MethodInvoker)delegate
                    {
                        chkRecording.Checked = false;
                    });
                    break;

                default:
                    state = "State unknown";
                    break;
            }
            Console.WriteLine(state);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            txtWebsocketHost.Text = Properties.Settings.Default.WebsocketHost;
            txtWebsocketPassword.Text = Properties.Settings.Default.WebsocketPassword;
            txtMicroflexHost.Text = Properties.Settings.Default.MicroflexHost;
            mappings = JsonConvert.DeserializeObject<Dictionary<string, int>>(Properties.Settings.Default.SceneMapping);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obs.IsConnected && Properties.Settings.Default.WebsocketHost != txtWebsocketHost.Text)
            {
                _obs.Disconnect();
            }
            Properties.Settings.Default.WebsocketHost = txtWebsocketHost.Text;
            Properties.Settings.Default.WebsocketPassword = txtWebsocketPassword.Text;
            Properties.Settings.Default.MicroflexHost = txtMicroflexHost.Text;
            Properties.Settings.Default.SceneMapping = JsonConvert.SerializeObject(mappings);
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtWebsocketHost.Text = Properties.Settings.Default.WebsocketHost;
            txtWebsocketPassword.Text = Properties.Settings.Default.WebsocketPassword;
            txtMicroflexHost.Text = Properties.Settings.Default.MicroflexHost;
        }

        private void tmrShureStatus_TickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("Checking Connection to Shure Microflex");
            sendShureMessage("< GET LED_COLOR_UNMUTED >");
        }

        private void cmboColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            mappings[lstSources.SelectedItem.ToString()] = cmboColours.SelectedIndex;
        }

        private void tmrWebsocketConnect_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Checking connection to OBS Websocket");
            if (_obs.IsConnected)
            {
                lblCurrentScene.Text = _obs.Api.GetCurrentScene().Name;
                chkStreaming.Checked = _obs.Api.GetStreamingStatus().IsStreaming;
                chkRecording.Checked = _obs.Api.GetStreamingStatus().IsRecording;
                Console.WriteLine("OBS IS CONNECTED");
            }
            else
            {
                Console.WriteLine("OBS IS DISCONNECTED");
                try
                {
                    _obs.Connect("ws://" + Properties.Settings.Default.WebsocketHost + ":4444", Properties.Settings.Default.WebsocketPassword);
                }
                catch (AuthFailureException)
                {
                    MessageBox.Show("Authentication failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ErrorResponseException ex)
                {
                    MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lstSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scene = (string)lstSources.SelectedItem;
            cmboColours.Enabled = true;
            if (!mappings.ContainsKey(scene))
            {
                mappings[scene] = 0;
            }
            cmboColours.SelectedIndex = mappings[scene];
        }
    }
}
