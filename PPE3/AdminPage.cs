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
    public partial class AdminPage : Form
    {
        string usernameSelected = "";
        public AdminPage()
        {
            InitializeComponent();
            UserDataAccess dataAccess = new();
            this.dataGridView1.DataSource = dataAccess.SelectUsersFromDB();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new();
            addUser.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (usernameSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un utilisateur");
            }
            else
            {
                UserDataAccess dataAccess = new();
                dataAccess.DeleteUserOnDB(usernameSelected);
                this.dataGridView1.DataSource = dataAccess.SelectUsersFromDB();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                this.usernameSelected = selectedRow.Cells["Username"].Value.ToString();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new()
            {
                DataSource = dataGridView1.DataSource,
                Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'"
            };
            dataGridView1.DataSource = bs;
        }
    }
}
