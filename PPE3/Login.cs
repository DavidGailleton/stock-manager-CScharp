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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userData = new UserDataAccess();
            string result = userData.VerifyUserFromDB(usernameTextBox.Text.ToString().ToLower(), passwordTextBox.Text.ToString());
            if (result == "admin")
            {
                AdminPage ap = new();
                ap.Show();
            } else if (result == "user")
            {
                Index index = new();
                index.Show();
            }
        }
    }
}
