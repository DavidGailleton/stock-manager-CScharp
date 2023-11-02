using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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

        public void addDrugToDB(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new DrugDataAccess();
                DataTable dbData = dataAccess.importDrugFromDB();

                bool checkIfAlreadyInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            return true;
                        }
                    }
                    return false;

                }

                if (checkIfAlreadyInDB(dbData, drug) == true)
                {
                    string query = "UPDATE drug SET quantity = quantity + 1 WHERE name = @name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        int result = command.ExecuteNonQuery();
                    }

                }
                else
                {
                    string query = "INSERT INTO drug (name, description, quantity) VALUES (@name, @description, 1)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        int result = command.ExecuteNonQuery();
                    }
                }

                
                conn.Close();
            }
        }

        public void addDrugFromDBWithQuantity(Drug drug, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new DrugDataAccess();
                DataTable dbData = dataAccess.importDrugFromDB();

                bool checkIfAlreadyInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            return true;
                        }
                    }
                    return false;

                }

                if (checkIfAlreadyInDB(dbData, drug) == true)
                {
                    string query = "UPDATE drug SET quantity = quantity + @quantity WHERE name = @name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }

                }
                else
                {
                    string query = "INSERT INTO drug (name, description, quantity) VALUES (@name, @description, @quantity)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public DataTable importDrugFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, description, quantity FROM drug";
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

        public DataTable importAuthorizedDrugFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, description FROM authorized_drugs";
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

        public string deleteDrugFromDB(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // delete row on db from name
                conn.Open();
                string query = "DELETE FROM drug WHERE name = @name AND description = @description";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    command.ExecuteNonQuery();
                    return "Référence totalement supprimé du stock";
                }
            }
        }

        public string deleteDrugFromDBWithQuantity(Drug drug, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new DrugDataAccess();
                DataTable dbData = dataAccess.importDrugFromDB();

                int checkQuantityInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            int result = Convert.ToInt32(row["quantity"]);
                            return result;
                        }
                    }
                    return -1;

                }

                if (checkQuantityInDB(dbData, drug) > quantity)
                {
                    string query = "UPDATE drug SET quantity = quantity - @quantity WHERE name = @name AND description = @description";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                    return "Quantité choisie supprimé du stock";
                } else if (checkQuantityInDB(dbData, drug) == quantity)
                {
                    return deleteDrugFromDB(drug);
                } else
                {
                    return "la quantité choisie n'est pas valide";
                }
                
            }
        }

        public void editDrugFromDB(string originalName, string newName, string newDescription)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE drug SET name = @newName, description = @newDescription WHERE name = @originalName";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@originalName", originalName);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newDescription", newDescription);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
