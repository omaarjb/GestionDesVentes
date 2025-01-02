using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();
            welcomeAdmin.Text += UserSession.Username;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void adminAddCategories1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void clients_btn_Click(object sender, EventArgs e)
        {

        }











        private void decBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm form1 = new LoginForm();
                form1.Show();
                this.Hide();
            }
        }



        private void catBtn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddUsers1.Visible = false;
            adminHistorique1.Visible = false;

            adminAddUsers adminUsers = adminAddUsers1 as adminAddUsers;

            if (adminUsers != null)
            {
                adminUsers.refreshData();
            }
        }

        private void productBtn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminHistorique1.Visible = false;


            adminAddProducts adminProd = adminAddProducts1 as adminAddProducts;

            if (adminProd != null)
            {
                adminProd.refreshData();
            }
        }

        private void usersBtn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = true;
            adminHistorique1.Visible = false;

            adminAddUsers adminUsers = adminAddUsers1 as adminAddUsers;

            if (adminUsers != null)
            {
                adminUsers.refreshData();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminHistorique1.Visible = false;

            adminDashboard adminDashboard = adminDashboard1 as adminDashboard;

            if (adminDashboard != null)
            {
                adminDashboard.refreshData();
            }
        }

        private void histBtn_Click_1(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddUsers1.Visible = false;
            adminHistorique1.Visible = true;

            adminHistorique adminCust = adminHistorique1 as adminHistorique;

            if (adminCust != null)
            {
                adminCust.refreshData();
            }
        }
    }
}
