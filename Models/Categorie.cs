using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    internal class Categorie
    {
        string connectionString = DatabaseConfig.ConnectionString;

        public int ID { set; get; }
        public string Category { set; get; }
        public string Status { set; get; }
        public DateTime Date { set; get; }
        public List<Categorie> listAddCategoriesData()
        {
            List<Categorie> listData = new List<Categorie>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectCategoriesData = "SELECT * FROM categories";
                using (SqlCommand selectCategoriesDataCmd = new SqlCommand(selectCategoriesData, conn))
                {
                    SqlDataReader reader = selectCategoriesDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Categorie adminAddCategoriesData = new Categorie();
                        adminAddCategoriesData.ID = (int)reader["id"];
                        adminAddCategoriesData.Category = (string)reader["category"];
                        adminAddCategoriesData.Status = (string)reader["status"].ToString();
                        adminAddCategoriesData.Date = ((DateTime)reader["date_created"]);

                        listData.Add(adminAddCategoriesData);
                    }
                }
            }

            return listData;
        }



    }
}
