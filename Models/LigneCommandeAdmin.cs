using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    internal class LigneCommandeAdmin
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime DateTransaction { get; set; }

        public List<LigneCommandeAdmin> customerDataList()
        {
            List<LigneCommandeAdmin> listData = new List<LigneCommandeAdmin>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectProduitsData = "SELECT * FROM transactions";
                using (SqlCommand selectProduitsDataCmd = new SqlCommand(selectProduitsData, conn))
                {
                    SqlDataReader reader = selectProduitsDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LigneCommandeAdmin adminCustomersData = new LigneCommandeAdmin();
                        adminCustomersData.ID = (int)reader["id"];

                        adminCustomersData.CustomerId = (int)reader["idClient"];
                        adminCustomersData.TotalPrice = reader["prixTotal"].ToString();
                        adminCustomersData.DateTransaction = ((DateTime)reader["dateTransaction"]);
                        adminCustomersData.Status = reader["statut"].ToString();


                        listData.Add(adminCustomersData);
                    }
                }
            }

            return listData;
        }

    }
}
