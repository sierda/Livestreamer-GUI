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
    public partial class TwitchChatWindow : Form
    {
        public TwitchChatWindow(string url) : this(url, url.Substring(21, url.IndexOf('/', 22) - 21)) { }
        public TwitchChatWindow(string url, string title)
        {
            InitializeComponent();

            this.Text = title;
            this.Show();
            this.webBrowser1.Navigate(url);
        }

        private void TwitchChatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser1.Dispose();
            webBrowser1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
