using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userData = new UserDataAccess();
            string result = userData.verifyUserFromDB(usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString());
            if (result == "done")
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
