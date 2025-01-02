using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class customerHistoriqueCommande : UserControl
    {
        public customerHistoriqueCommande()
        {
            InitializeComponent();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomersCommandes();
        }

        public void displayCustomersCommandes()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new HistoriqueDesCommandesClients().customerCommandeDataList();

            if (dataGridView1.Columns.Contains("ID"))
            {
                dataGridView1.Columns.Remove("ID");
            }


        }
    }
}
