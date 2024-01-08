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
    public partial class ListPatient : Form
    {
        public ListPatient()
        {
            InitializeComponent();
            PatientDataAccess dataAccess = new PatientDataAccess();
            this.dataGridView1.DataSource = dataAccess.SelectPatientsFromDB;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void select_button_Click(object sender, EventArgs e)
        {
        }
    }
}
