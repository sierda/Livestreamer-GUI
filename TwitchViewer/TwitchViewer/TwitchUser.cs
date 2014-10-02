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
    class TwitchUser
    {
        private static readonly string TWITCH_API_FOLLOWED_USERS = @"https://api.twitch.tv/kraken/users/{0}/follows/channels?sortby=last_broadcast&limit=50";

        public string Name { get; private set; }
        public TwitchStream Stream { get; private set; }

        private TwitchUser(string username) : this(username, true) { }

        private TwitchUser(string username, bool fetchStream)
        {
            Name = username;
            if (fetchStream)
                Stream = TwitchStream.GetStream(this);
            else
                Stream = null;
        }

        public static TwitchUser GetUser(string s)
        {
            return new TwitchUser(s);
        }

        public bool HasStream()
        {
            return (Stream != null);
        }

        public bool FetchStream()
        {

            Stream = TwitchStream.GetStream(this);
            return HasStream();
        }

        public List<TwitchUser> GetFollowedUsers()
        {
             return GetFollowedUsers(true);
        }

        public List<TwitchUser> GetFollowedUsers(bool getStreams)
        {
            List<TwitchUser> followed = null;
            string request = String.Format(TWITCH_API_FOLLOWED_USERS, this.Name);

            //Web stuff
            try
            {
                WebRequest wq = WebRequest.Create(request);
                WebResponse wr = wq.GetResponse();
                Stream s = wr.GetResponseStream();
                StreamReader reader = new StreamReader(s);

                String responseJSON = reader.ReadToEnd();
                dynamic responseObject = JObject.Parse(responseJSON);
                if ((responseObject.follows != null))
                {
                    followed = new List<TwitchUser>();
                    for(int i = 0; i < responseObject.follows.Count; i++)
                    {
                        string name = (string)(responseObject.follows)[i].channel.name;
                        try
                        {
                            followed.Add(new TwitchUser(name, getStreams));
                        }
                        finally { ;}
                    }
                }

                reader.Close();
                wr.Close();

                return followed;
            }
            catch (WebException)
            {
                return null;
            }
        }
    }
}
