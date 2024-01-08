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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void NewDrugButton_Click(object sender, EventArgs e)
        {
            NewDrug newDrug = new NewDrug();
            newDrug.Show();
        }

        private void EditDrugButton_Click(object sender, EventArgs e)
        {
            DrugInStock editDrug = new DrugInStock();
            editDrug.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPatient listPatient = new ListPatient();
            listPatient.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }
    }
}
