using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class AddPatient : Form
    {
        string sexe = null;
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            PatientDataAccess dataAccess = new PatientDataAccess();
            dataAccess.AddPatientInDB(surname_textbox.Text, name_textbox.Text, birthday_DateTimePicker.Value.Date, sexe);
        }

        private void homme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "h";
            if (femme_checkBox.Checked == true)
            {
                femme_checkBox.Checked = false;
            }
        }

        private void femme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "f";
            if (homme_checkBox.Checked == true)
            {
                homme_checkBox.Checked = false;
            }
        }
    }
}
