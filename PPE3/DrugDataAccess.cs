using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE3
{
    internal class DrugDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private List<Drug> drugs = new List<Drug>();

        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }

        public List<Drug> getDrugList() { return this.drugs; }

        public int addDrugToDB(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO drug (name, description) VALUES (@name, @description)";
                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
                conn.Close();
            }
        }

        public DataTable importDrugFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, description FROM drug";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    DataSet ds = new DataSet();
                    MySqlCommand sqlcmd = new MySqlCommand(query, conn);
                    DataTable dt = new DataTable();
                    var reader = sqlcmd.ExecuteReader();
                    dt.Load(reader);


                    return dt;


                }
                conn.Close();
            }
        }
    }
}
