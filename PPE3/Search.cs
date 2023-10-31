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
    public partial class Search : Form
    {
        string nameSelected;
        string descriptionSelected;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
            nameSelected = selectedRow.Cells["Name"].Value.ToString();
            descriptionSelected = selectedRow.Cells["Description"].Value.ToString();
        }
    }
}
