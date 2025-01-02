using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    class Utilisateur
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public DateTime Date { set; get; }
        public List<Utilisateur> listAddUsersData()
        {
            List<Utilisateur> listData = new List<Utilisateur>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectUsersData = "SELECT * FROM users";
                using (SqlCommand selectUsersDataCmd = new SqlCommand(selectUsersData, conn))
                {
                    SqlDataReader reader = selectUsersDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Utilisateur adminAddUsersData = new Utilisateur();
                        adminAddUsersData.ID = (int)reader["id"];
                        adminAddUsersData.Username = (string)reader["username"].ToString();
                        adminAddUsersData.Password = (string)reader["password"].ToString();
                        adminAddUsersData.Role = (string)reader["role"].ToString();
                        adminAddUsersData.Status = (string)reader["status"].ToString();
                        adminAddUsersData.Date = ((DateTime)reader["date_register"]);

                        listData.Add(adminAddUsersData);
                    }
                }
            }

            return listData;
        }



    }
}
