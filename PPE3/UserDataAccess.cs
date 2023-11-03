using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace PPE3
{
    internal class UserDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private List<User> users= new List<User>();

        public string addUserInDB(string username, string password, bool admin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (username, password, admin) VALUES (@username, @password, @admin)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@admin", admin);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        return "Error";
                    }
                    else
                    {
                        return "Success";
                    }
                }
            }
        }

        public string verifyUserFromDB(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT username, password, admin FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand sqlcmd = new MySqlCommand(query, conn))
                {
                    sqlcmd.Parameters.AddWithValue("@username", username);
                    sqlcmd.Parameters.AddWithValue("@password", password);

                    var reader = sqlcmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User newUser = new User(reader.GetString(0), reader.GetString(1), (int)reader.GetDecimal(2));
                            if (newUser.Admin == 1)
                            {
                                MessageBox.Show("admin");
                                AdminPage ap = new AdminPage();
                                ap.Show();
                                return "done";
                            }
                            else
                            {
                                MessageBox.Show("user");
                                Index index = new Index();
                                index.Show();
                                return "done";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                        return "not done";
                    }
                    
                   
                }
                return "not done";
            }
        }


    }
}
