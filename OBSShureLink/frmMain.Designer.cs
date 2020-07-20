namespace OBSShureLink
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblSources = new System.Windows.Forms.Label();
            this.cmboColours = new System.Windows.Forms.ComboBox();
            this.lstSources = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picMicroflexStatus = new System.Windows.Forms.PictureBox();
            this.txtMicroflexHost = new System.Windows.Forms.TextBox();
            this.lblMicroflexHost = new System.Windows.Forms.Label();
            this.picWebsocketStatus = new System.Windows.Forms.PictureBox();
            this.txtWebsocketHost = new System.Windows.Forms.TextBox();
            this.lblWebsocketHost = new System.Windows.Forms.Label();
            this.tmrShureStatus = new System.Windows.Forms.Timer(this.components);
            this.lblHostSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebsocketPassword = new System.Windows.Forms.TextBox();
            this.lblWebsocketPassword = new System.Windows.Forms.Label();
            this.tmrWebsocketConnect = new System.Windows.Forms.Timer(this.components);
            this.lblTitleCurrentScene = new System.Windows.Forms.Label();
            this.lblCurrentScene = new System.Windows.Forms.Label();
            this.lblCurrentColour = new System.Windows.Forms.Label();
            this.lblTitleCurrentColour = new System.Windows.Forms.Label();
            this.chkStreaming = new System.Windows.Forms.CheckBox();
            this.chkRecording = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMicroflexStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsocketStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(165, 155);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(113, 13);
            this.lblColour.TabIndex = 7;
            this.lblColour.Text = "Shure Microflex Colour";
            // 
            // lblSources
            // 
            this.lblSources.AutoSize = true;
            this.lblSources.Location = new System.Drawing.Point(12, 155);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(66, 13);
            this.lblSources.TabIndex = 6;
            this.lblSources.Text = "OBS Source";
            // 
            // cmboColours
            // 
            this.cmboColours.FormattingEnabled = true;
            this.cmboColours.Items.AddRange(new object[] {
            "RED",
            "GREEN",
            "BLUE",
            "PINK",
            "PURPLE",
            "YELLOW",
            "ORANGE",
            "WHITE",
            "GOLD",
            "YELLOWGREEN",
            "TURQUOISE",
            "POWDERBLUE",
            "CYAN",
            "SKYBLUE",
            "LIGHTPURPLE",
            "VIOLET",
            "ORCHID"});
            this.cmboColours.Location = new System.Drawing.Point(168, 171);
            this.cmboColours.Name = "cmboColours";
            this.cmboColours.Size = new System.Drawing.Size(118, 21);
            this.cmboColours.TabIndex = 5;
            this.cmboColours.SelectedIndexChanged += new System.EventHandler(this.cmboColours_SelectedIndexChanged);
            // 
            // lstSources
            // 
            this.lstSources.FormattingEnabled = true;
            this.lstSources.Location = new System.Drawing.Point(15, 171);
            this.lstSources.Name = "lstSources";
            this.lstSources.Size = new System.Drawing.Size(120, 95);
            this.lstSources.TabIndex = 4;
            this.lstSources.SelectedIndexChanged += new System.EventHandler(this.lstSources_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picMicroflexStatus
            // 
            this.picMicroflexStatus.BackColor = System.Drawing.Color.Red;
            this.picMicroflexStatus.Location = new System.Drawing.Point(260, 376);
            this.picMicroflexStatus.Name = "picMicroflexStatus";
            this.picMicroflexStatus.Size = new System.Drawing.Size(20, 20);
            this.picMicroflexStatus.TabIndex = 13;
            this.picMicroflexStatus.TabStop = false;
            // 
            // txtMicroflexHost
            // 
            this.txtMicroflexHost.Location = new System.Drawing.Point(154, 376);
            this.txtMicroflexHost.Name = "txtMicroflexHost";
            this.txtMicroflexHost.Size = new System.Drawing.Size(100, 20);
            this.txtMicroflexHost.TabIndex = 12;
            // 
            // lblMicroflexHost
            // 
            this.lblMicroflexHost.AutoSize = true;
            this.lblMicroflexHost.Location = new System.Drawing.Point(12, 379);
            this.lblMicroflexHost.Name = "lblMicroflexHost";
            this.lblMicroflexHost.Size = new System.Drawing.Size(105, 13);
            this.lblMicroflexHost.TabIndex = 11;
            this.lblMicroflexHost.Text = "Shure Microflex Host";
            // 
            // picWebsocketStatus
            // 
            this.picWebsocketStatus.BackColor = System.Drawing.Color.Red;
            this.picWebsocketStatus.Location = new System.Drawing.Point(260, 324);
            this.picWebsocketStatus.Name = "picWebsocketStatus";
            this.picWebsocketStatus.Size = new System.Drawing.Size(20, 20);
            this.picWebsocketStatus.TabIndex = 10;
            this.picWebsocketStatus.TabStop = false;
            // 
            // txtWebsocketHost
            // 
            this.txtWebsocketHost.Location = new System.Drawing.Point(154, 324);
            this.txtWebsocketHost.Name = "txtWebsocketHost";
            this.txtWebsocketHost.Size = new System.Drawing.Size(100, 20);
            this.txtWebsocketHost.TabIndex = 9;
            // 
            // lblWebsocketHost
            // 
            this.lblWebsocketHost.AutoSize = true;
            this.lblWebsocketHost.Location = new System.Drawing.Point(12, 327);
            this.lblWebsocketHost.Name = "lblWebsocketHost";
            this.lblWebsocketHost.Size = new System.Drawing.Size(112, 13);
            this.lblWebsocketHost.TabIndex = 8;
            this.lblWebsocketHost.Text = "OBS Websocket Host";
            // 
            // tmrShureStatus
            // 
            this.tmrShureStatus.Enabled = true;
            this.tmrShureStatus.Interval = 5000;
            this.tmrShureStatus.Tick += new System.EventHandler(this.tmrShureStatus_TickAsync);
            // 
            // lblHostSettings
            // 
            this.lblHostSettings.AutoSize = true;
            this.lblHostSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostSettings.Location = new System.Drawing.Point(15, 284);
            this.lblHostSettings.Name = "lblHostSettings";
            this.lblHostSettings.Size = new System.Drawing.Size(110, 18);
            this.lblHostSettings.TabIndex = 16;
            this.lblHostSettings.Text = "Host Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Scene Colour Mapping";
            // 
            // txtWebsocketPassword
            // 
            this.txtWebsocketPassword.Location = new System.Drawing.Point(154, 350);
            this.txtWebsocketPassword.Name = "txtWebsocketPassword";
            this.txtWebsocketPassword.PasswordChar = '•';
            this.txtWebsocketPassword.Size = new System.Drawing.Size(100, 20);
            this.txtWebsocketPassword.TabIndex = 19;
            // 
            // lblWebsocketPassword
            // 
            this.lblWebsocketPassword.AutoSize = true;
            this.lblWebsocketPassword.Location = new System.Drawing.Point(12, 353);
            this.lblWebsocketPassword.Name = "lblWebsocketPassword";
            this.lblWebsocketPassword.Size = new System.Drawing.Size(136, 13);
            this.lblWebsocketPassword.TabIndex = 18;
            this.lblWebsocketPassword.Text = "OBS Websocket Password";
            // 
            // tmrWebsocketConnect
            // 
            this.tmrWebsocketConnect.Enabled = true;
            this.tmrWebsocketConnect.Interval = 10000;
            this.tmrWebsocketConnect.Tick += new System.EventHandler(this.tmrWebsocketConnect_Tick);
            // 
            // lblTitleCurrentScene
            // 
            this.lblTitleCurrentScene.AutoSize = true;
            this.lblTitleCurrentScene.Location = new System.Drawing.Point(12, 9);
            this.lblTitleCurrentScene.Name = "lblTitleCurrentScene";
            this.lblTitleCurrentScene.Size = new System.Drawing.Size(75, 13);
            this.lblTitleCurrentScene.TabIndex = 20;
            this.lblTitleCurrentScene.Text = "Current Scene";
            // 
            // lblCurrentScene
            // 
            this.lblCurrentScene.AutoSize = true;
            this.lblCurrentScene.Location = new System.Drawing.Point(12, 35);
            this.lblCurrentScene.Name = "lblCurrentScene";
            this.lblCurrentScene.Size = new System.Drawing.Size(50, 13);
            this.lblCurrentScene.TabIndex = 21;
            this.lblCurrentScene.Text = "<Scene>";
            // 
            // lblCurrentColour
            // 
            this.lblCurrentColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentColour.Location = new System.Drawing.Point(179, 35);
            this.lblCurrentColour.Name = "lblCurrentColour";
            this.lblCurrentColour.Size = new System.Drawing.Size(107, 13);
            this.lblCurrentColour.TabIndex = 23;
            this.lblCurrentColour.Text = "<Colour>";
            this.lblCurrentColour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitleCurrentColour
            // 
            this.lblTitleCurrentColour.AutoSize = true;
            this.lblTitleCurrentColour.Location = new System.Drawing.Point(212, 9);
            this.lblTitleCurrentColour.Name = "lblTitleCurrentColour";
            this.lblTitleCurrentColour.Size = new System.Drawing.Size(74, 13);
            this.lblTitleCurrentColour.TabIndex = 22;
            this.lblTitleCurrentColour.Text = "Current Colour";
            // 
            // chkStreaming
            // 
            this.chkStreaming.AutoSize = true;
            this.chkStreaming.Enabled = false;
            this.chkStreaming.Location = new System.Drawing.Point(12, 64);
            this.chkStreaming.Name = "chkStreaming";
            this.chkStreaming.Size = new System.Drawing.Size(73, 17);
            this.chkStreaming.TabIndex = 24;
            this.chkStreaming.Text = "Streaming";
            this.chkStreaming.UseVisualStyleBackColor = true;
            // 
            // chkRecording
            // 
            this.chkRecording.AutoSize = true;
            this.chkRecording.Enabled = false;
            this.chkRecording.Location = new System.Drawing.Point(12, 87);
            this.chkRecording.Name = "chkRecording";
            this.chkRecording.Size = new System.Drawing.Size(75, 17);
            this.chkRecording.TabIndex = 25;
            this.chkRecording.Text = "Recording";
            this.chkRecording.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 453);
            this.Controls.Add(this.chkRecording);
            this.Controls.Add(this.chkStreaming);
            this.Controls.Add(this.lblCurrentColour);
            this.Controls.Add(this.lblTitleCurrentColour);
            this.Controls.Add(this.lblCurrentScene);
            this.Controls.Add(this.lblTitleCurrentScene);
            this.Controls.Add(this.txtWebsocketPassword);
            this.Controls.Add(this.lblWebsocketPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHostSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picMicroflexStatus);
            this.Controls.Add(this.txtMicroflexHost);
            this.Controls.Add(this.lblMicroflexHost);
            this.Controls.Add(this.picWebsocketStatus);
            this.Controls.Add(this.txtWebsocketHost);
            this.Controls.Add(this.lblWebsocketHost);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblSources);
            this.Controls.Add(this.cmboColours);
            this.Controls.Add(this.lstSources);
            this.Name = "frmMain";
            this.Text = "OBS Shure LED Link";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMicroflexStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsocketStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblSources;
        private System.Windows.Forms.ComboBox cmboColours;
        private System.Windows.Forms.ListBox lstSources;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picMicroflexStatus;
        private System.Windows.Forms.TextBox txtMicroflexHost;
        private System.Windows.Forms.Label lblMicroflexHost;
        private System.Windows.Forms.PictureBox picWebsocketStatus;
        private System.Windows.Forms.TextBox txtWebsocketHost;
        private System.Windows.Forms.Label lblWebsocketHost;
        private System.Windows.Forms.Timer tmrShureStatus;
        private System.Windows.Forms.Label lblHostSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebsocketPassword;
        private System.Windows.Forms.Label lblWebsocketPassword;
        private System.Windows.Forms.Timer tmrWebsocketConnect;
        private System.Windows.Forms.Label lblTitleCurrentScene;
        private System.Windows.Forms.Label lblCurrentScene;
        private System.Windows.Forms.Label lblCurrentColour;
        private System.Windows.Forms.Label lblTitleCurrentColour;
        private System.Windows.Forms.CheckBox chkStreaming;
        private System.Windows.Forms.CheckBox chkRecording;
    }
}