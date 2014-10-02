namespace TwitchViewer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelLivestreamerPath = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoOpenChat = new System.Windows.Forms.CheckBox();
            this.buttonCustomStream = new System.Windows.Forms.Button();
            this.checkBoxAutoFetch = new System.Windows.Forms.CheckBox();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.buttonFetchStreams = new System.Windows.Forms.Button();
            this.labelQuality = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userGetter = new System.ComponentModel.BackgroundWorker();
            this.followedUsersGetter = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openStreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRCJoinStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(0, 13);
            this.labelHeader.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(8, 19);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 13);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "User Name";
            // 
            // labelLivestreamerPath
            // 
            this.labelLivestreamerPath.AutoSize = true;
            this.labelLivestreamerPath.Location = new System.Drawing.Point(230, 19);
            this.labelLivestreamerPath.Name = "labelLivestreamerPath";
            this.labelLivestreamerPath.Size = new System.Drawing.Size(92, 13);
            this.labelLivestreamerPath.TabIndex = 22;
            this.labelLivestreamerPath.Text = "Livestreamer Path";
            // 
            // textBoxUser
            // 
            this.textBoxUser.AllowDrop = true;
            this.textBoxUser.Location = new System.Drawing.Point(74, 16);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // textBoxPath
            // 
            this.textBoxPath.AllowDrop = true;
            this.textBoxPath.Location = new System.Drawing.Point(328, 16);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(150, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.checkBoxAutoOpenChat);
            this.groupBoxSettings.Controls.Add(this.buttonCustomStream);
            this.groupBoxSettings.Controls.Add(this.checkBoxAutoFetch);
            this.groupBoxSettings.Controls.Add(this.comboBoxQuality);
            this.groupBoxSettings.Controls.Add(this.buttonFetchStreams);
            this.groupBoxSettings.Controls.Add(this.labelQuality);
            this.groupBoxSettings.Controls.Add(this.labelUser);
            this.groupBoxSettings.Controls.Add(this.buttonSave);
            this.groupBoxSettings.Controls.Add(this.textBoxPath);
            this.groupBoxSettings.Controls.Add(this.labelLivestreamerPath);
            this.groupBoxSettings.Controls.Add(this.textBoxUser);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(688, 79);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxAutoOpenChat
            // 
            this.checkBoxAutoOpenChat.AutoSize = true;
            this.checkBoxAutoOpenChat.Location = new System.Drawing.Point(404, 46);
            this.checkBoxAutoOpenChat.Name = "checkBoxAutoOpenChat";
            this.checkBoxAutoOpenChat.Size = new System.Drawing.Size(102, 17);
            this.checkBoxAutoOpenChat.TabIndex = 7;
            this.checkBoxAutoOpenChat.Text = "Auto-Open Chat";
            this.checkBoxAutoOpenChat.UseVisualStyleBackColor = true;
            // 
            // buttonCustomStream
            // 
            this.buttonCustomStream.Location = new System.Drawing.Point(223, 42);
            this.buttonCustomStream.Name = "buttonCustomStream";
            this.buttonCustomStream.Size = new System.Drawing.Size(99, 23);
            this.buttonCustomStream.TabIndex = 6;
            this.buttonCustomStream.Text = "Custom Stream";
            this.buttonCustomStream.UseVisualStyleBackColor = true;
            this.buttonCustomStream.Click += new System.EventHandler(this.buttonCustomStream_Click);
            // 
            // checkBoxAutoFetch
            // 
            this.checkBoxAutoFetch.AutoSize = true;
            this.checkBoxAutoFetch.Location = new System.Drawing.Point(512, 46);
            this.checkBoxAutoFetch.Name = "checkBoxAutoFetch";
            this.checkBoxAutoFetch.Size = new System.Drawing.Size(167, 17);
            this.checkBoxAutoFetch.TabIndex = 8;
            this.checkBoxAutoFetch.Text = "Auto-Fetch streams on startup";
            this.checkBoxAutoFetch.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Items.AddRange(new object[] {
            "best",
            "high",
            "medium",
            "low",
            "mobile"});
            this.comboBoxQuality.Location = new System.Drawing.Point(529, 16);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(150, 21);
            this.comboBoxQuality.TabIndex = 3;
            this.comboBoxQuality.Text = "best";
            // 
            // buttonFetchStreams
            // 
            this.buttonFetchStreams.Location = new System.Drawing.Point(11, 42);
            this.buttonFetchStreams.Name = "buttonFetchStreams";
            this.buttonFetchStreams.Size = new System.Drawing.Size(100, 23);
            this.buttonFetchStreams.TabIndex = 4;
            this.buttonFetchStreams.Text = "Fetch Streams";
            this.buttonFetchStreams.UseVisualStyleBackColor = true;
            this.buttonFetchStreams.Click += new System.EventHandler(this.buttonFetchStreams_Click);
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(484, 19);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(39, 13);
            this.labelQuality.TabIndex = 23;
            this.labelQuality.Text = "Quality";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(117, 42);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save Settings";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(712, 22);
            this.statusStrip1.TabIndex = 24;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBoxSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 420);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 320);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // userGetter
            // 
            this.userGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.userGetter_DoWork);
            this.userGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.userGetter_RunWorkerCompleted);
            // 
            // followedUsersGetter
            // 
            this.followedUsersGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.followedUsersGetter_DoWork);
            this.followedUsersGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.followedUsersGetter_RunWorkerCompleted);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStreamToolStripMenuItem,
            this.openChatToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.fetchStreamsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 92);
            // 
            // openStreamToolStripMenuItem
            // 
            this.openStreamToolStripMenuItem.Name = "openStreamToolStripMenuItem";
            this.openStreamToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openStreamToolStripMenuItem.Text = "Open Stream";
            this.openStreamToolStripMenuItem.Click += new System.EventHandler(this.openStreamToolStripMenuItem_Click);
            // 
            // openChatToolStripMenuItem
            // 
            this.openChatToolStripMenuItem.Name = "openChatToolStripMenuItem";
            this.openChatToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openChatToolStripMenuItem.Text = "Open Chat";
            this.openChatToolStripMenuItem.Click += new System.EventHandler(this.openChatToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRCJoinStringToolStripMenuItem,
            this.usernameToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // iRCJoinStringToolStripMenuItem
            // 
            this.iRCJoinStringToolStripMenuItem.Name = "iRCJoinStringToolStripMenuItem";
            this.iRCJoinStringToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.iRCJoinStringToolStripMenuItem.Text = "IRC Join String";
            this.iRCJoinStringToolStripMenuItem.Click += new System.EventHandler(this.iRCJoinStringToolStripMenuItem_Click);
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            // 
            // fetchStreamsToolStripMenuItem
            // 
            this.fetchStreamsToolStripMenuItem.Name = "fetchStreamsToolStripMenuItem";
            this.fetchStreamsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.fetchStreamsToolStripMenuItem.Text = "Fetch Streams For this User";
            this.fetchStreamsToolStripMenuItem.Click += new System.EventHandler(this.fetchStreamsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonFetchStreams;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelHeader);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(728, 240);
            this.Name = "MainForm";
            this.Text = "Livestreamer GUI";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelLivestreamerPath;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonFetchStreams;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAutoFetch;
        private System.ComponentModel.BackgroundWorker userGetter;
        private System.ComponentModel.BackgroundWorker followedUsersGetter;
        private System.Windows.Forms.Button buttonCustomStream;
        private System.Windows.Forms.CheckBox checkBoxAutoOpenChat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openStreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRCJoinStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchStreamsToolStripMenuItem;
    }
}

