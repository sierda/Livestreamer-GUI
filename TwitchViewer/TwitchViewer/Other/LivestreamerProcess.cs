using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitchViewer
{
    class LivestreamerProcess : System.Diagnostics.Process
    {
        private string lsPath;
        private string url;
        private string quality;

        public LivestreamerProcess(string lsPath, TwitchUser t, string q) : this(lsPath, t.Stream.Url, q) {}
        public LivestreamerProcess(string lsPath, string u, string q)
        {
            this.lsPath = lsPath;
            this.url = u;
            this.quality = q;
        }

        new public bool Start()
        {
            this.StartInfo.FileName = lsPath;
            this.StartInfo.Arguments = url + " " + quality;
            try
            {
                base.Start();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}