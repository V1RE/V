using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace V_1._2
{
    class getMsg
    {
        WebClient downloader = new WebClient();
        public static string webmsg = null;
        public static string oldmsg = null;

        public void update(string _address)
        {
            bool isup = checkIfOnline.isup();
            if (isup == true)
            {
                webmsg = downloader.DownloadString(_address);
                if (webmsg != oldmsg)
                {
                    oldmsg = webmsg;
                    if (webmsg.StartsWith("Server Broadcast: ") || webmsg.StartsWith("|SB|"))
                    {
                        MainView._MainView.updateChat(webmsg, false);
                    }
                    else
                    {
                        MainView._MainView.updateChat(webmsg, true);
                    }
                }
            }
        }
    }
}
