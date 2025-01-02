using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class adminHistorique : UserControl
    {
        public adminHistorique()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }

        public void displayCustomers()
        {
            LigneCommandeAdmin ligneCommandeAdmin = new LigneCommandeAdmin();
            dataGridView1.DataSource = ligneCommandeAdmin.customerDataList();
        }

        private void adminHistorique_Load(object sender, System.EventArgs e)
        {

        }
    }
}
