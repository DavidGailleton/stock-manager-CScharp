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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            string result = dataAccess.addUserInDB(usernameTextBox.Text, passwordTextBox.Text, adminCheckBox.Checked);
            if (result == "Success")
            {
                MessageBox.Show("Utilisateur ajouté");
                AdminPage ap = new AdminPage();
                ap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
    }
}
