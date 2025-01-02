using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente.Resources
{
    internal class LigneCommandeCaissier
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int CustomerId { get; set; }
        public string TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime DateTransaction { get; set; }
        public int OrderId { get; set; }
        public int CaisseId { get; set; }



        public List<LigneCommandeCaissier> customerDataList()
        {
            int caissierId = UserSession.UserId;
            List<LigneCommandeCaissier> listData = new List<LigneCommandeCaissier>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectProduitsData = "SELECT * FROM transactions WHERE caissier_id=@caissierId";
                using (SqlCommand selectProduitsDataCmd = new SqlCommand(selectProduitsData, conn))
                {
                    selectProduitsDataCmd.Parameters.AddWithValue("@caissierId", caissierId);
                    SqlDataReader reader = selectProduitsDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LigneCommandeCaissier customerTransactionsData = new LigneCommandeCaissier();

                        customerTransactionsData.CustomerId = (int)reader["idClient"];
                        customerTransactionsData.TotalPrice = reader["prixTotal"].ToString();
                        customerTransactionsData.Status = reader["statut"].ToString();
                        customerTransactionsData.DateTransaction = ((DateTime)reader["dateTransaction"]);
                        customerTransactionsData.OrderId = (int)reader["order_id"];
                        customerTransactionsData.CaisseId = (int)reader["caissier_id"];



                        listData.Add(customerTransactionsData);
                    }
                }
            }

            return listData;

        }


    }

}
