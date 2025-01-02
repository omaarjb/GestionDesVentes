using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class adminDashboard : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarj\OneDrive\Documents\patDB.mdf;Integrated Security=True;Connect Timeout=30";
        LigneCommandeAdmin adminCustomersData = new LigneCommandeAdmin();
        public adminDashboard()
        {
            InitializeComponent();
            displayTotalCaissier();
            displayTotalOrders();
            displayProfit();
            displayTotalProfit();
            dataGridView1.DataSource = adminCustomersData.customerDataList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalCaissier();
            displayTotalOrders();
            displayProfit();
            displayTotalProfit();
            dataGridView1.DataSource = adminCustomersData.customerDataList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void displayTotalCaissier()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string caissierCount = "SELECT count(id) as totalCaissier FROM users where role='Caissier'";
                using (SqlCommand caissierCountCmd = new SqlCommand(caissierCount, conn))
                {
                    SqlDataReader reader = caissierCountCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalCaissier"] != DBNull.Value)
                        {
                            int totalCaiss = (int)reader["totalCaissier"];
                            totalCaissier.Text = totalCaiss.ToString();
                        }


                    }
                }
            }
        }

        public void displayTotalOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string orderCount = "SELECT count(id) as totalOrders FROM transactions";
                using (SqlCommand orderCountCmd = new SqlCommand(orderCount, conn))
                {
                    SqlDataReader reader = orderCountCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalOrders"] != DBNull.Value)
                        {
                            int totalOrd = (int)reader["totalOrders"];
                            totalOrders.Text = totalOrd.ToString();
                        }


                    }
                }
            }
        }
        public void displayProfit()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                DateTime today = DateTime.Now;
                string selectTodayProfit = "SELECT SUM(prixTotal) as profit FROM transactions WHERE dateTransaction='" + today + "'";
                using (SqlCommand selectTodayProfitCmd = new SqlCommand(selectTodayProfit, conn))
                {
                    SqlDataReader reader = selectTodayProfitCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["profit"] != DBNull.Value)
                        {
                            decimal todayProf = Convert.ToDecimal(reader["profit"]);
                            todayProfit.Text = todayProf.ToString() + " Dhs";
                        }


                    }
                }
            }
        }


        public void displayTotalProfit()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string selectTotalProf = "SELECT SUM(prixTotal) as TotalProfit FROM transactions";
                using (SqlCommand selectTotalProfCmd = new SqlCommand(selectTotalProf, conn))
                {
                    SqlDataReader reader = selectTotalProfCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["TotalProfit"] != DBNull.Value)
                        {
                            decimal totalProf = Convert.ToDecimal(reader["TotalProfit"]);
                            totalProfit.Text = totalProf.ToString() + " Dhs";
                        }


                    }
                }
            }
        }

        private void totalOrders_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
