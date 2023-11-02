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
        string nameSelected = "";
        string descriptionSelected = "";

        public Search()
        {
            InitializeComponent();
            //importer les donnée de la table "drug" avec MySql.data
            DrugDataAccess dataAccess = new DrugDataAccess();
            this.dataGridView1.DataSource = dataAccess.importDrugFromDB();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
            else
            {
                EditDrug editdrug = new EditDrug(nameSelected, descriptionSelected);
                editdrug.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                nameSelected = selectedRow.Cells["Name"].Value.ToString();
                descriptionSelected = selectedRow.Cells["Description"].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
            else
            {
                //supprimer la ligne de valeur séléctionner dans la base de donnée
                DrugDataAccess dataAccess = new DrugDataAccess();
                Drug selectedDrug = new Drug(nameSelected, descriptionSelected);
                dataAccess.deleteDrugFromDB(selectedDrug);
                this.dataGridView1.DataSource = dataAccess.importDrugFromDB();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void deleteWithQuantityButton_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
            else
            {
                int quantity = (int)numericQuantityDelete.Value;
                DrugDataAccess dataAccess = new DrugDataAccess();
                Drug selectedDrug = new Drug(nameSelected, descriptionSelected);
                dataAccess.deleteDrugFromDBWithQuantity(selectedDrug, quantity);
                this.dataGridView1.DataSource = dataAccess.importDrugFromDB();
            }
        }
    }
}
