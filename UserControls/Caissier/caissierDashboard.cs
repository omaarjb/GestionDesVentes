using GestionDeVente.Resources;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionDeVente
{

    public partial class caissierDashboard : UserControl
    {
        string connectionString = DatabaseConfig.ConnectionString;
        LigneCommandeCaissier customerTransactionsData = new LigneCommandeCaissier();
        public caissierDashboard()
        {

            InitializeComponent();
            displayProfit();
            displayTotalProfit();
            displayTotalCaissier();
            displayTotalOrdersByCashier(UserSession.UserId);
            dataGridView1.DataSource = customerTransactionsData.customerDataList();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalCaissier();
            displayTotalOrdersByCashier(UserSession.UserId);
            displayProfit();
            displayTotalProfit();
            dataGridView1.DataSource = customerTransactionsData.customerDataList();


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

        public void displayTotalOrdersByCashier(int cashierId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string orderCount = "SELECT COUNT(id) AS totalOrders FROM orders WHERE caissierId = @caissierId";
                using (SqlCommand orderCountCmd = new SqlCommand(orderCount, conn))
                {

                    orderCountCmd.Parameters.AddWithValue("@caissierId", cashierId);

                    SqlDataReader reader = orderCountCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["totalOrders"] != DBNull.Value)
                        {
                            int totalOrd = (int)reader["totalOrders"];
                            totalOrders.Text = totalOrd.ToString();
                        }
                        else
                        {
                            totalOrders.Text = "0";
                        }
                    }
                }
            }
        }


        public void displayProfit()
        {
            int caissier_id = UserSession.UserId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                DateTime today = DateTime.Now;
                string selectTodayProfit = "SELECT SUM(prixTotal) as profit FROM transactions WHERE dateTransaction='" + today + "' AND caissier_id=@caissier_id";
                using (SqlCommand selectTodayProfitCmd = new SqlCommand(selectTodayProfit, conn))
                {

                    selectTodayProfitCmd.Parameters.AddWithValue("@caissier_id", caissier_id);
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
            int caissier_id = UserSession.UserId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string selectTotalProf = "SELECT SUM(prixTotal) as TotalProfit FROM transactions WHERE caissier_id=@caissier_id";
                using (SqlCommand selectTotalProfCmd = new SqlCommand(selectTotalProf, conn))
                {
                    selectTotalProfCmd.Parameters.AddWithValue("@caissier_id", caissier_id);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void todayProfit_Click(object sender, EventArgs e)
        {

        }
    }
}
