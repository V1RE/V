using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_1._2
{
    public partial class JoinChannelForm : Form
    {
        string _sender;
        string _channel;

        public JoinChannelForm(string sender, string channel)
        {
            InitializeComponent();
            _sender = sender;
            _channel = channel;
        }

        private void JoinChannelForm_Load(object sender, EventArgs e)
        {
            label1.Text = _sender + " invited you to join " + _channel;
            this.Text = "Channel invitation"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmds.commands("/channel " + _channel);
            MainView._MainView.showwindow();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
