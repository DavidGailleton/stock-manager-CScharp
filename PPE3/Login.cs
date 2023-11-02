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
            UserDataAccess userData = new UserDataAccess();
            userData.verifyUserFromDB(usernameTextBox.ToString(), passwordTextBox.ToString());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
