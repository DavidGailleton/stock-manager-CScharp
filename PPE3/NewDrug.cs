using System.Xml.Linq;

namespace PPE3
{
    public partial class NewDrug : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public NewDrug()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            //dataAccess.addDrug(drug);
            int result = dataAccess.addDrugToDB(drug);
            MessageBox.Show(result.ToString());
            updateDataGridWiew();
        }

        public void updateDataGridWiew()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.getDrugList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();

                EditDrug formDetails = new EditDrug(name, description);
                formDetails.Show();
            }
        }

    }
}