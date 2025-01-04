using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    internal class Commande
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int CaissierId { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string ProductName { get; set; }




        public List<Commande> listOrders()
        {
            List<Commande> listData = new List<Commande>();
            int getClientId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectClientId = "SELECT max(idClient) as idClient FROM orders";
                using (SqlCommand selectClientIdCmd = new SqlCommand(selectClientId, conn))
                {
                    using (SqlDataReader readClientId = selectClientIdCmd.ExecuteReader())
                    {
                        if (readClientId.Read())
                        {
                            if (readClientId["idClient"] != DBNull.Value)
                            {
                                getClientId = (int)readClientId["idClient"];
                            }
                        }


                    }
                }
                string getOrders = "SELECT * FROM orders WHERE idClient = " + getClientId;
                using (SqlCommand getOrdersCmd = new SqlCommand(getOrders, conn))
                {
                    using (SqlDataReader reader = getOrdersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande caissierOrdersData = new Commande();
                            caissierOrdersData.ID = (int)reader["id"];
                            caissierOrdersData.CustomerID = (int)reader["idClient"];
                            caissierOrdersData.CaissierId = (int)reader["caissierId"];
                            caissierOrdersData.Price = reader["prix"].ToString();
                            caissierOrdersData.Quantity = reader["quantite"].ToString();
                            caissierOrdersData.ProductName = reader["prodName"].ToString();

                            listData.Add(caissierOrdersData);

                        }
                    }
                }

                return listData;
            }
        }
    }
}
