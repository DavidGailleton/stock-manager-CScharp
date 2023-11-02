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
    public partial class EditDrug : Form
    {
        string originalName;
        public EditDrug(string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
            originalName = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") || !textBox2.Text.Equals(""))
            {
                // use editDrugFromDB function
                DrugDataAccess dataAccess = new DrugDataAccess();
                dataAccess.editDrugFromDB(this.originalName, textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void EditDrug_Load(object sender, EventArgs e)
        {
        }
    }
}
