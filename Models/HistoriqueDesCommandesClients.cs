using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    internal class HistoriqueDesCommandesClients
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int ID { get; set; }
        public int CustomerId { get; set; }

        public string Prix { get; set; }
        public int Quantite { get; set; }
        public string Status { get; set; }
        public DateTime DateCommande { get; set; }
        public int Caissier_id { get; set; }

        public List<HistoriqueDesCommandesClients> customerCommandeDataList()
        {
            List<HistoriqueDesCommandesClients> listData = new List<HistoriqueDesCommandesClients>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectProduitsData = "SELECT idClient,prix,quantite,statut,dateCommande,caissierId FROM orders";
                using (SqlCommand selectProduitsDataCmd = new SqlCommand(selectProduitsData, conn))
                {
                    SqlDataReader reader = selectProduitsDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        HistoriqueDesCommandesClients customersHitsoriqueCommandeData = new HistoriqueDesCommandesClients();

                        customersHitsoriqueCommandeData.CustomerId = (int)reader["idClient"];

                        customersHitsoriqueCommandeData.Prix = reader["prix"].ToString();
                        customersHitsoriqueCommandeData.Quantite = (int)reader["quantite"];
                        customersHitsoriqueCommandeData.Status = reader["statut"].ToString();
                        customersHitsoriqueCommandeData.DateCommande = ((DateTime)reader["dateCommande"]);
                        customersHitsoriqueCommandeData.Caissier_id = (int)reader["caissierId"];

                        listData.Add(customersHitsoriqueCommandeData);
                    }
                }
            }

            return listData;
        }


    }
}