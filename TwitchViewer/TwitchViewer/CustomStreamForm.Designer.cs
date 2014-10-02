namespace TwitchViewer
{
    partial class CustomStreamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomStreamForm));
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonWatch = new System.Windows.Forms.Button();
            this.checkBoxOpenChat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.comboBoxQuality.Location = new System.Drawing.Point(246, 12);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(130, 21);
            this.comboBoxQuality.TabIndex = 10;
            this.comboBoxQuality.Text = "best";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(201, 15);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(39, 13);
            this.labelQuality.TabIndex = 9;
            this.labelQuality.Text = "Quality";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(5, 15);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 13);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "User Name";
            // 
            // textBoxUser
            // 
            this.textBoxUser.AllowDrop = true;
            this.textBoxUser.Location = new System.Drawing.Point(71, 12);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(124, 20);
            this.textBoxUser.TabIndex = 8;
            // 
            // buttonWatch
            // 
            this.buttonWatch.Location = new System.Drawing.Point(465, 10);
            this.buttonWatch.Name = "buttonWatch";
            this.buttonWatch.Size = new System.Drawing.Size(75, 23);
            this.buttonWatch.TabIndex = 11;
            this.buttonWatch.Text = "Watch";
            this.buttonWatch.UseVisualStyleBackColor = true;
            this.buttonWatch.Click += new System.EventHandler(this.buttonWatch_Click);
            // 
            // checkBoxOpenChat
            // 
            this.checkBoxOpenChat.AutoSize = true;
            this.checkBoxOpenChat.Location = new System.Drawing.Point(382, 14);
            this.checkBoxOpenChat.Name = "checkBoxOpenChat";
            this.checkBoxOpenChat.Size = new System.Drawing.Size(77, 17);
            this.checkBoxOpenChat.TabIndex = 12;
            this.checkBoxOpenChat.Text = "Open Chat";
            this.checkBoxOpenChat.UseVisualStyleBackColor = true;
            // 
            // CustomStreamForm
            // 
            this.AcceptButton = this.buttonWatch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 45);
            this.Controls.Add(this.checkBoxOpenChat);
            this.Controls.Add(this.buttonWatch);
            this.Controls.Add(this.comboBoxQuality);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomStreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomStreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonWatch;
        private System.Windows.Forms.CheckBox checkBoxOpenChat;

    }
}