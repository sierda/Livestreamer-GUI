using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TwitchViewer
{
    public partial class MainForm : Form
    {
        private TwitchUser mainUser;
        private List<TwitchUser> followed_users;
        private DataTable liveTable;
        private int fetchedUsers;

        public MainForm()
        {
            InitializeComponent();

            //load settings
            textBoxUser.Text = (string)Properties.Settings.Default["DefaultTwitchUser"];
            textBoxPath.Text = (string)Properties.Settings.Default["LiveStreamerPath"];
            checkBoxAutoFetch.Checked = (bool)Properties.Settings.Default["AutoFetchStreams"];
            checkBoxAutoOpenChat.Checked = (bool)Properties.Settings.Default["AutoOpenChat"];

            this.Show();

            followed_users = new List<TwitchUser>();
            fetchedUsers = 0;
            FillTable(ref dataGridView1);

            if (checkBoxAutoFetch.Checked)
                buttonFetchStreams_Click(this, new EventArgs());
        }

        private void buttonFetchStreams_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Getting user...";

            string user = textBoxUser.Text;
            if (!userGetter.IsBusy && !followedUsersGetter.IsBusy)
            {
                buttonFetchStreams.Enabled = false;
                userGetter.RunWorkerAsync(user);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["DefaultTwitchUser"] = textBoxUser.Text;
            Properties.Settings.Default["LiveStreamerPath"] = textBoxPath.Text;
            Properties.Settings.Default["AutoFetchStreams"] = checkBoxAutoFetch.Checked;
            Properties.Settings.Default["AutoOpenChat"] = checkBoxAutoOpenChat.Checked;
            Properties.Settings.Default.Save();

            toolStripStatusLabel1.Text = "Settings saved!";
        }

        //function to set up datatable used by the gridview
        private void FillTable(ref DataGridView dgv)
        {
            liveTable = new DataTable();
            liveTable.Columns.Add(new DataColumn("User"));
            liveTable.Columns.Add(new DataColumn("Viewers"));
            liveTable.Columns[1].DataType = typeof(UInt32);
            liveTable.Columns.Add(new DataColumn("Game"));
            liveTable.Columns.Add(new DataColumn("Title"));

            dgv.DataSource = liveTable;

            dgv.Columns["User"].Width = 140;
            dgv.Columns["User"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgv.Columns["Viewers"].Width = 75;
            dgv.Columns["Viewers"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgv.Columns["Game"].Width = 140;
            dgv.Columns["Game"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //dgv.Columns["Title"].Width = 325;
            dgv.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void openStream(string username)
        {
            string lsPath = textBoxPath.Text;
            string quality = comboBoxQuality.Text;
            TwitchUser user = searchUser(username, ref followed_users);

            if (user != null)
            {
                LivestreamerProcess lsp = new LivestreamerProcess(lsPath, user, quality);
                if (lsp.Start())
                {
                    //open chat on successful stream open if wanted
                    if (checkBoxAutoOpenChat.Checked)
                        new TwitchChatWindow(user.Stream.Url + "/chat");
                }
                else
                    toolStripStatusLabel1.Text = "Error openeing livestreamer. Bad path?";

                lsp.Close();
            }
        }

        private TwitchUser searchUser(string username, ref List<TwitchUser> list)
        {
            foreach (TwitchUser t in list)
            {
                if (t.Name == username)
                {
                    return t;
                }
            }
            return null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get twitch user corresponding to clicked row
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string clickedName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                openStream(clickedName);
            }
        }

        private void userGetter_DoWork(object sender, DoWorkEventArgs e)
        {
            mainUser = TwitchUser.GetUser((string)e.Argument);
        }

        private void userGetter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Getting followed streams...";
            if (!followedUsersGetter.IsBusy)
                followedUsersGetter.RunWorkerAsync();
        }

        private void followedUsersGetter_DoWork(object sender, DoWorkEventArgs e)
        {
            followed_users = mainUser.GetFollowedUsers(false);
        }

        private void followedUsersGetter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (followed_users != null)
            {
                //clear table
                fetchedUsers = 0;
                liveTable.Rows.Clear();

                foreach (TwitchUser t in followed_users)
                {
                    toolStripStatusLabel1.Text = "Fetching followed streams...";
                    BackgroundWorker bw = new BackgroundWorker();

                    bw.DoWork += delegate
                    {
                        if (!t.HasStream())
                            t.FetchStream();
                    };

                    bw.RunWorkerCompleted += delegate
                    {
                        //report progress to user
                        fetchedUsers++;
                        toolStripStatusLabel1.Text = String.Format("Fetched {0}/{1} streams...", fetchedUsers, followed_users.Count);

                        //add row to table if live
                        if (t.HasStream())
                        {
                            DataRow dr;
                            dr = liveTable.NewRow();
                            dr["User"] = t.Name;
                            dr["Viewers"] = t.Stream.Viewers;
                            dr["Game"] = t.Stream.Game;
                            dr["Title"] = t.Stream.Title;
                            liveTable.Rows.Add(dr);
                        }

                        //done getting all streams
                        if(fetchedUsers == followed_users.Count)
                        { 
                            toolStripStatusLabel1.Text = ""; 
                            buttonFetchStreams.Enabled = true; 
                        }
                            
                    };

                    bw.RunWorkerAsync();
                }
                toolStripStatusLabel1.Text = "";
                dataGridView1.Focus();
            }
            else
            {
                toolStripStatusLabel1.Text = "Error fetching followed streams...";
                buttonFetchStreams.Enabled = true; 
            }
        }

        private void buttonCustomStream_Click(object sender, EventArgs e)
        {
            new CustomStreamForm();
        }

        private void openStreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clickedName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            openStream(clickedName);
        }

        private void openChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clickedName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            TwitchUser user = searchUser(clickedName, ref followed_users);
            new TwitchChatWindow(user.Stream.Url + "/chat");
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);
                    this.contextMenuStrip1.Show(dataGridView1, relativeMousePosition);
                }
            }
        }

        private void iRCJoinStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clickedName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Clipboard.SetText("/join #" + clickedName.ToLower());
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clickedName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Clipboard.SetText(clickedName);
        }

        private void fetchStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clickedName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            textBoxUser.Text = clickedName;
            buttonFetchStreams_Click(sender, e);
        }
    }
}
