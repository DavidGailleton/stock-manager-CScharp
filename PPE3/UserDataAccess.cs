using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            User newUser = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            newUser = new User(reader["username"].ToString(), reader["Description"].ToString(), (bool)reader["admin"]);
                           
                        }
                        if(newUser.Admin == true)
                        {
                            AdminPage adminpage = new AdminPage();
                            adminpage.Show();
                            Index index = new Index();
                            index.Show();
                            return "Connected";
                        } else if (newUser.Admin == true) {
                            Index index = new Index();
                            index.Show();
                            return "Connected";
                        }
                    }
                }
            }
            return "Mauvais nom ou MDP";
        }

    }
}
