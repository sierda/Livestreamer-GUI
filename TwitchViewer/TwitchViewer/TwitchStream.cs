using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewer
{
    class TwitchStream
    {
        private static readonly string TWITCH_API_GET_STREAM = @"https://api.twitch.tv/kraken/streams/{0}";

        public string Title { get; private set; }
        public string Game { get; private set; }
        public string Url { get; private set; }
        public string Thumbnail { get; private set; }
        public uint Viewers { get; private set; }

        private TwitchStream(string t, string g, string u, string th, uint v)
        {
            Title = t;
            Game = g;
            Url = u;
            Thumbnail = th;
            Viewers = v;
        }

        public static TwitchStream GetStream(TwitchUser u)
        {
            TwitchStream twitchStream = null;
            string request = String.Format(TWITCH_API_GET_STREAM, u.Name);

            //Web stuff
            try
            {
                WebRequest wq = WebRequest.Create(request);
                WebResponse wr = wq.GetResponse();
                Stream s = wr.GetResponseStream();
                StreamReader reader = new StreamReader(s);

                String responseJSON = reader.ReadToEnd();
                dynamic responseObject = JObject.Parse(responseJSON);
                if ((responseObject.stream != null))
                {
                    string title = (string)responseObject.stream.channel.status;
                    string game = (string)responseObject.stream.game;
                    string url = (string)responseObject.stream.channel.url;
                    string thumbnail = (string)responseObject.stream.preview.large;
                    uint viewers = (uint)responseObject.stream.viewers;

                    twitchStream = new TwitchStream(title, game, url, thumbnail, viewers);
                }

                reader.Close();
                wr.Close();

                return twitchStream;
            }
            catch (WebException)
            {
                return null;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", this.Url, this.Title, this.Game, this.Viewers);
        }
    }
}
