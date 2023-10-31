using System.Xml.Linq;

namespace PPE3
{
    public partial class Form1 : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            dataAccess.addDrug(drug);

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
    }
}