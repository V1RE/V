using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace V_1._2
{
    class cmds
    {
        public static void commands(string _cmd)
        {
            if (_cmd.StartsWith("/connect"))
            {
                try
                {
                    string _newaddress;
                    if (!_cmd.Replace("/connect ", "").StartsWith("http"))
                    {
                        _newaddress = _cmd.Replace("/connect ", "http://");
                    }
                    else
                    {
                        _newaddress = _cmd.Replace("/connect ", "");
                    }
                    var web = new WebClient();
                    string _welcome = web.DownloadString(_newaddress + "/welcome.txt");
                    sndMsg.sendhi(MainView._address + MainView.phpfile, "Server Broadcast: " + MainView.username + " left the server");
                    MainView._address = _newaddress;
                    MainView._MainView.AppendChat("Succsessfully switched hosts to " + _newaddress.Replace("http://", "") + "\n", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                    MainView._MainView.AppendChat(_welcome + "\n", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                    sndMsg.sendhi(_newaddress + MainView.phpfile, "Server Broadcast: " + MainView.username + " joined the server");
                }
                catch (Exception)
                {
                    MainView._MainView.AppendChat("This address is invalid, please try another address", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                }
            }
            else if (_cmd.StartsWith("/channel"))
            {
                string _tmp = _cmd.Replace("/channel ", "");
                if (_tmp != "")
                {
                    string _enc = _tmp;
                    for (int i = 0; i < 3; i++)
                    {
                        _enc = RijndaelManagedEncryption.EncryptRijndael(_enc, MainView.stdsalt);
                    }
                    MainView._MainView.AppendChat("Switched channel to " + _tmp + "\n", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                    MainView.channel = _tmp;
                    MainView.salt = _enc;
                }
                else
                {
                    MainView._MainView.AppendChat("Switched channel to Default channel\n", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                    MainView.salt = MainView.stdchannel;
                }
            }
            else if (_cmd.StartsWith("/username "))
            {
                string _tmp = _cmd.Replace("/username ", "").Replace(" ", "-");
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                string newuname = rgx.Replace(_tmp, "");
                if (newuname.Length >= 3 && newuname.Length <= 20)
                {
                    sndMsg.sendhi(MainView._address + MainView.phpfile, "Server Broadcast: " + MainView.username + " changed his or her username to " + newuname);
                    MainView.username = newuname;
                }
                else
                {
                    MainView._MainView.AppendChat("Please make sure your username contains at least 3 characters and is shorter than 20.\n", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                }
            }
            else if (_cmd == "/x" || _cmd == "/exit")
            {
                Application.Exit();
            }
            else if (_cmd == "/cls" || _cmd == "/clear")
            {
                MainView._MainView.clearChat();
            }
            else if (_cmd.StartsWith("/invite "))
            {
                string _tmp = _cmd.Replace("/invite ", "").Replace("@", "");
                string txttosend = RijndaelManagedEncryption.EncryptRijndael("@" + _tmp + "|" + MainView.username + "|" + MainView.channel, MainView.bcSalt);
                sndMsg.sendhi(MainView._address + MainView.phpfile, "|SB|" + txttosend);
            }
            else
            {
                MainView._MainView.AppendChat(_cmd + " is not a valid command", System.Drawing.Color.Red, System.Drawing.Color.Yellow);
            }
        }
    }
}
