using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionDeVente
{
    internal class Produits
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public int ID { get; set; }
        public string IdProd { get; set; }
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public string Prix { get; set; }
        public string Stock { get; set; }
        public string Statut { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }


        public List<Produits> listAddProductsData()
        {
            List<Produits> listData = new List<Produits>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectProduitsData = "SELECT * FROM produits";
                using (SqlCommand selectProduitsDataCmd = new SqlCommand(selectProduitsData, conn))
                {
                    SqlDataReader reader = selectProduitsDataCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Produits adminAddProductsData = new Produits();
                        adminAddProductsData.ID = (int)reader["id"];
                        adminAddProductsData.IdProd = reader["idProd"].ToString();
                        adminAddProductsData.Nom = reader["nom"].ToString();
                        adminAddProductsData.Categorie = reader["categorie"].ToString();
                        adminAddProductsData.Prix = reader["prix"].ToString();
                        adminAddProductsData.Stock = reader["stock"].ToString();
                        adminAddProductsData.Statut = reader["statut"].ToString();
                        adminAddProductsData.Date = ((DateTime)reader["date_ajout"]);
                        adminAddProductsData.Image = reader["image"].ToString();

                        listData.Add(adminAddProductsData);
                    }
                }
            }

            return listData;
        }



    }
}
