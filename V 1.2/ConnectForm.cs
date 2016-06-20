using System;
using System.Windows.Forms;

namespace V_1._2
{
    public partial class ConnectForm : Form
    {
        string _oldadress;
        public ConnectForm(string oldaddress)
        {
            InitializeComponent();
            _oldadress = oldaddress;
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            IPBox.Text = _oldadress;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string newaddress = IPBox.Text;
            cmds.commands("/connect " + newaddress);
            this.Close();
        }
    }
}
