using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace V_1._2
{
    public partial class MainView : Form
    {
        public static string _address = "http://94.209.75.174";
        public static string username = Environment.UserName.Replace(" ","-");
        public static string chatfile = "/chat.txt";
        public static string phpfile = "/V.php";
        public static string stdsalt = "4nN2SADvm1QveR+M/3kv6uPuQ0jbZLpTByuZ/F6d/w7HLxdSnyelMIwoTDr7Myna";
        public static string stdchannel = "p/Vm5l8WFL4rOGmX5lrhgmYCmdju2BWx+sY8VMWpOk89pI5WcVCh1Bc4kfMk0Qzd";
        public static string salt = "p/Vm5l8WFL4rOGmX5lrhgmYCmdju2BWx+sY8VMWpOk89pI5WcVCh1Bc4kfMk0Qzd";
        public static string channel = "Default channel";
        public static string bcSalt = "p/Vm5l8WFL4rOGmX5Sny4nN2SADvm1QveR+M/3kv6uPuQ0jbZLVCh1Bc4kfMk0Qzd";
        public static bool minimized = false;
        public MainView()
        {
            InitializeComponent();
            _MainView = this;
        }

        public static MainView _MainView;
        public void updateChat(string final_text, bool encrypted)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                if (encrypted)
                {
                    try
                    {
                        string txttowrite = RijndaelManagedEncryption.DecryptRijndael(final_text, salt);
                        if (txttowrite.Contains("@" + username.ToLower()))
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            string[] usrandmsg = txttowrite.Split('>');
                            AppendChat(txttowrite + "\n", Color.Red);
                            MessageBox.Show(this, usrandmsg[1], usrandmsg[0].Replace("[", "").Replace("]", "") + " poked you.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                            notifyIcon1_Click(this, null);
                        }
                        else
                        {
                            try
                            {
                                string msgcolor = txttowrite.Split('>')[1].Split('$')[1];
                                string msgbackcolor = txttowrite.Split('>')[1].Split('^')[1];
                                AppendChat(txttowrite.Replace("$" + msgcolor + "$", "").Replace("^" + msgbackcolor + "^", "") + "\n", Color.FromName(msgcolor), Color.FromName(msgbackcolor));
                            }
                            catch
                            {
                                try
                                {
                                    string msgcolor = txttowrite.Split('>')[1].Split('$')[1];
                                    AppendChat(txttowrite.Replace("$" + msgcolor + "$", "") + "\n", Color.FromName(msgcolor));
                                }
                                catch
                                {
                                    try
                                    {
                                        string msgbackcolor = txttowrite.Split('>')[1].Split('^')[1];
                                        AppendChat(txttowrite.Replace("^" + msgbackcolor + "^", "") + "\n", null, Color.FromName(msgbackcolor));
                                    }
                                    catch
                                    {
                                        AppendChat(txttowrite + "\n");
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        string txttowrite = RijndaelManagedEncryption.DecryptRijndael(final_text.Replace("|SB|", ""), bcSalt);
                        if (txttowrite.ToLower().StartsWith("@" + username.ToLower()))
                        {
                            String[] assets = txttowrite.Split('|');
                            Form joinchannel = new JoinChannelForm(assets[1], assets[2]);
                            joinchannel.Show();
                        }
                    }
                    catch
                    {
                        AppendChat(final_text + "\n", Color.Red, Color.Yellow);
                    }

                }
                chatHistoryMsgBox.SelectionStart = chatHistoryMsgBox.TextLength;
                chatHistoryMsgBox.ScrollToCaret();
                updateTitle();
            });
        }

        public void AppendChat(string text, Color? color = null, Color? backColor = null)
        {
            chatHistoryMsgBox.SelectionStart = chatHistoryMsgBox.TextLength;
            chatHistoryMsgBox.SelectionLength = 0;
            chatHistoryMsgBox.SelectionColor = color ?? chatHistoryMsgBox.ForeColor;
            chatHistoryMsgBox.SelectionBackColor = backColor ?? Color.White;

            chatHistoryMsgBox.AppendText(text);

            chatHistoryMsgBox.SelectionColor = chatHistoryMsgBox.ForeColor;
            chatHistoryMsgBox.SelectionBackColor = chatHistoryMsgBox.BackColor;
        }

        public void updateAddress(string _newaddress)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                _address = _newaddress;
                updateTitle();
            });
        }

        public void updateTitle()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                MainView._MainView.Text = username + "@" + _address.Replace("http://", "");
            });
        }

        public void clearChat()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                chatHistoryMsgBox.Clear();
            });
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            sndMsg.sendhi(_address + phpfile, "Server Broadcast: " + MainView.username + " joined the server");
            Thread check = new Thread(checkthread);
            check.IsBackground = true;
            check.Start();
        }

        private void checkthread()
        {
            getMsg messagereciever = new getMsg();
            bool isup = checkIfOnline.isup();
            while (true)
            {
                while (isup)
                {
                    int i = 0;
                    for (i = 0; i < 100; i++)
                    {
                        try
                        {
                            messagereciever.update(_address + chatfile);
                        }
                        catch
                        {

                        }
                    }
                    isup = checkIfOnline.isup();
                }
                isup = checkIfOnline.isup();
            }
        }

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            if (sendMsgBox.Text != "")
            {
                string msg = sendMsgBox.Text;
                if (msg.ToLower().StartsWith("/"))
                {
                    cmds.commands(msg);
                }
                else
                {
                    sndMsg.send(_address + phpfile, msg, username, salt);
                }
            }
            sendMsgBox.Text = "";
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form connector = new ConnectForm(_address);
            connector.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form unameform = new UsernameForm();
            unameform.Show();
        }

        private void channelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form channelform = new ChannelForm();
            channelform.Show();
        }

        private void MainView_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                minimized = true;
            }
        }

        public void showwindow()
        {
            notifyIcon1_Click(this, null);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            minimized = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
