using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewer
{
    public partial class CustomStreamForm : Form
    {
        private readonly string TWITCH_URL_FORMAT = @"http://www.twitch.tv/{0}";

        public CustomStreamForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void buttonWatch_Click(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default["LiveStreamerPath"].ToString();
            string quality = comboBoxQuality.Text;
            string url = String.Format(TWITCH_URL_FORMAT, textBoxUser.Text);

            LivestreamerProcess lsp = new LivestreamerProcess(path, url, quality);
            if (!lsp.Start())
                MessageBox.Show("Error openeing livestreamer\nBad path?");
            else
            {
                if (checkBoxOpenChat.Checked)
                    new TwitchChatWindow(url + "/chat");
                this.Close();
            }
        }
    }
}
