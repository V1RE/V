using System;
using System.Windows.Forms;

namespace V_1._2
{
    public partial class UsernameForm : Form
    {
        public UsernameForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string newuname = uNameBox.Text;
            cmds.commands("/username " + newuname);
            this.Close();
        }

        private void UsernameForm_Load(object sender, EventArgs e)
        {
            uNameBox.Text = MainView.username;
        }
    }
}
