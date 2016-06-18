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
    public partial class ChannelForm : Form
    {
        public ChannelForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string command = ChannelBox.Text;
            cmds.commands("/channel " + command);
            this.Close();
        }

        private void ChannelForm_Load(object sender, EventArgs e)
        {
            string _enc = MainView.salt;
            for (int i = 0; i < 3; i++)
            {
                _enc = RijndaelManagedEncryption.DecryptRijndael(_enc, MainView.stdsalt);
            }
            ChannelBox.Text = _enc;
        }
    }
}
