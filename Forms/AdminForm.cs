using System;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            welcomeAdmin.Text += UserSession.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = true;
            adminCustomers1.Visible = false;

            adminAddUsers adminUsers = adminAddUsers1 as adminAddUsers;

            if (adminUsers != null)
            {
                adminUsers.refreshData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm form1 = new LoginForm();
                form1.Show();
                this.Hide();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;

            adminAddUsers adminUsers = adminAddUsers1 as adminAddUsers;

            if (adminUsers != null)
            {
                adminUsers.refreshData();
            }
        }

        private void adminAddCategories1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;

            adminDashboard adminDashboard = adminDashboard1 as adminDashboard;

            if (adminDashboard != null)
            {
                adminDashboard.refreshData();
            }


        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;


            adminAddProducts adminProd = adminAddProducts1 as adminAddProducts;

            if (adminProd != null)
            {
                adminProd.refreshData();
            }
        }

        private void clients_btn_Click(object sender, EventArgs e)
        {

        }

        private void clients_btn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = true;

            adminHistorique adminCust = adminCustomers1 as adminHistorique;

            if (adminCust != null)
            {
                adminCust.refreshData();
            }
        }
    }
}
