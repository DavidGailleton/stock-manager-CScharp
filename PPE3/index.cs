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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void newDrugButton_Click(object sender, EventArgs e)
        {
            NewDrug newDrug = new NewDrug();
            newDrug.Show();
        }

        private void editDrugButton_Click(object sender, EventArgs e)
        {
            Search editDrug = new Search();
            editDrug.Show();
        }
    }
}
