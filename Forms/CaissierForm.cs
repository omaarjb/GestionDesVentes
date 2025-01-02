using MaterialSkin.Controls;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class CaissierForm : MaterialForm
    {
        public CaissierForm()
        {
            InitializeComponent();
            welcome.Text += UserSession.Username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void caissierCommandes1_Load(object sender, System.EventArgs e)
        {

        }






        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void dashBtn_Click(object sender, System.EventArgs e)
        {
            caissierDashboard1.Visible = true;
            caissierCommandes1.Visible = false;
            customerHistoriqueCommande1.Visible = false;

            caissierDashboard caissierDash = caissierDashboard1 as caissierDashboard;
            if (caissierDash != null)
            {
                caissierDash.refreshData();
            }
        }

        private void ordBtn_Click(object sender, System.EventArgs e)
        {
            caissierDashboard1.Visible = false;
            caissierCommandes1.Visible = true;
            customerHistoriqueCommande1.Visible = false;

            CaissierCommandes caissierCom = caissierCommandes1 as CaissierCommandes;
            if (caissierCom != null)
            {
                caissierCom.refreshData();
            }
        }

        private void histBtn_Click(object sender, System.EventArgs e)
        {
            caissierDashboard1.Visible = false;
            caissierCommandes1.Visible = false;
            customerHistoriqueCommande1.Visible = true;

            customerHistoriqueCommande custHist = customerHistoriqueCommande1 as customerHistoriqueCommande;
            if (custHist != null)
            {
                custHist.refreshData();
            }
        }

        private void decBtn_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Voulez vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm form1 = new LoginForm();
                form1.Show();
                this.Hide();
            }
        }

        private void customerHistoriqueCommande1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
