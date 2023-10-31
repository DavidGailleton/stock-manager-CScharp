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
        public EditDrug(string name, string description)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
                this.Close();
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
