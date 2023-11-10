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
    public partial class DrugInStock : Form
    {
        string nameSelected = "";
        string descriptionSelected = "";
        int quantitySelected;

        public DrugInStock()
        {
            InitializeComponent();
            //importer les donnée de la table "drug" avec MySql.data
            DrugDataAccess dataAccess = new DrugDataAccess();
            this.dataGridView1.DataSource = dataAccess.ImportDrugFromDB();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
            else
            {
                EditDrug editdrug = new EditDrug(nameSelected, descriptionSelected, quantitySelected);
                editdrug.Show();
                this.Close();
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                nameSelected = selectedRow.Cells["Name"].Value.ToString();
                descriptionSelected = selectedRow.Cells["Description"].Value.ToString();
                quantitySelected = (int)selectedRow.Cells["Quantity"].Value;

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
            else
            {
                //supprimer la ligne de valeur séléctionner dans la base de donnée
                DrugDataAccess dataAccess = new();
                Drug selectedDrug = new(nameSelected, descriptionSelected);
                dataAccess.DeleteDrugFromDB(selectedDrug);

                this.dataGridView1.DataSource = dataAccess.ImportDrugFromDB();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void DeleteWithQuantityButton_Click(object sender, EventArgs e)
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
                dataAccess.DeleteDrugFromDBWithQuantity(selectedDrug, quantity);
                this.dataGridView1.DataSource = dataAccess.ImportDrugFromDB();
            }
        }
    }
}
