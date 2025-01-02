using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace GestionDeVente
{
    public partial class CaissierCommandes : UserControl
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public CaissierCommandes()
        {
            InitializeComponent();
            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }

        public void displayAllOrders()
        {
            Commande caissierOrdersData = new Commande();
            dataGridView1.DataSource = caissierOrdersData.listOrders();
        }

        public void displayAvailableProducts()
        {
            Produits avProd = new Produits();

            dataGridView3.DataSource = avProd.listAddProductsData();
        }

        public void displayCategories()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectedCategories = "SELECT * FROM categories WHERE status = 'Active' ";
                using (SqlCommand selectedCategoriescmd = new SqlCommand(selectedCategories, conn))
                {
                    SqlDataReader reader = selectedCategoriescmd.ExecuteReader();
                    while (reader.Read())
                    {
                        orders_category.Items.Add(reader["category"]);
                    }
                }
            }
        }

        private void orders_category_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            orders_prodName.Text = "";
            orders_prodId.SelectedIndex = -1;
            orders_prodId.Items.Clear();
            orders_price.Text = "";
            orders_quantity.Value = 0;

            string selectedValue = orders_category.SelectedItem as string;
            if (selectedValue != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string selectedData = "SELECT * FROM produits WHERE categorie = @category AND statut = 'Active'";
                    using (SqlCommand selectedDatacmd = new SqlCommand(selectedData, conn))
                    {
                        selectedDatacmd.Parameters.AddWithValue("@category", selectedValue);
                        using (SqlDataReader reader = selectedDatacmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["idProd"].ToString();
                                orders_prodId.Items.Add(value);
                            }
                        }
                    }
                }
            }
        }

        private void orders_prodId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedValue = orders_prodId.SelectedItem as string;
            if (selectedValue != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string selectedData = "SELECT * FROM produits WHERE idProd=@prodId AND statut = 'Active'";
                    using (SqlCommand selectedDatacmd = new SqlCommand(selectedData, conn))
                    {
                        selectedDatacmd.Parameters.AddWithValue("@prodId", selectedValue);
                        using (SqlDataReader reader = selectedDatacmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prodName = reader["nom"].ToString();
                                string prodPrice = reader["prix"].ToString();
                                orders_prodName.Text = prodName;
                                orders_price.Text = prodPrice;
                            }
                        }
                    }
                }
            }

        }

        private void orders_addBtn_Click(object sender, System.EventArgs e)
        {
            if (orders_category.SelectedIndex == -1 || orders_prodId.SelectedIndex == -1 || orders_prodName.Text == "" || orders_price.Text == "" || orders_quantity.Value == 0)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertData = "INSERT INTO orders (idClient,prix, quantite, statut, dateCommande, caissierid) " +
                                "VALUES (@idClient, @prix, @quantite, @statut, @dateCommande, @caissierid)";
                    using (SqlCommand insertDatacmd = new SqlCommand(insertData, conn))
                    {
                        insertDatacmd.Parameters.AddWithValue("@idClient", generateID());
                        insertDatacmd.Parameters.AddWithValue("@prix", orders_price.Text.Trim());
                        insertDatacmd.Parameters.AddWithValue("@quantite", orders_quantity.Value);
                        insertDatacmd.Parameters.AddWithValue("@statut", "Pending");
                        DateTime today = DateTime.Today;
                        insertDatacmd.Parameters.AddWithValue("@dateCommande", today);
                        insertDatacmd.Parameters.AddWithValue("@caissierId", UserSession.UserId);

                        insertDatacmd.ExecuteNonQuery();
                        MessageBox.Show("Commande ajoutée avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayAllOrders();
            displayTotal();

        }

        public int generateID()
        {
            int getID = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT MAX(id) as getID FROM transactions";

                using (SqlCommand selectedDatacmd = new SqlCommand(selectData, conn))
                {
                    using (SqlDataReader reader = selectedDatacmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["getID"] != DBNull.Value)
                        {
                            getID = Convert.ToInt32(reader["getID"]);
                        }
                    }
                }
            }
            return getID + 1;
        }


        public void displayTotal()
        {
            orders_totalPrice.Text = getTotal().ToString();
        }


        public float getTotal()
        {
            float totalPrice = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectTotal = "SELECT prix , quantite FROM orders WHERE idClient = " + generateID();

                using (SqlCommand selectTotalcmd = new SqlCommand(selectTotal, conn))
                {
                    using (SqlDataReader reader = selectTotalcmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("prix")) && !reader.IsDBNull(reader.GetOrdinal("quantite")))
                            {
                                float price;
                                int qte;

                                if (float.TryParse(reader["prix"].ToString(), out price) && int.TryParse(reader["quantite"].ToString(), out qte))
                                {
                                    totalPrice += price * qte;
                                }
                            }

                        }
                    }
                }
            }
            return totalPrice;
        }

        public void clearFields()
        {
            orders_category.SelectedIndex = -1;
            orders_prodId.SelectedIndex = -1;
            orders_prodName.Text = ".....";
            orders_price.Text = ".....";
            orders_quantity.Value = 0;
        }

        private void orders_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void orders_montant_TextChanged(object sender, EventArgs e)
        {

        }

        public float getAmount()
        {
            return Convert.ToSingle(orders_montant.Text);
        }

        public float getChange()
        {
            return getAmount() - getTotal();
        }
        private void orders_montant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {


                    if (getAmount() < 0)
                    {
                        MessageBox.Show("Montant invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        orders_montant.Text = "";
                        orders_change.Text = "";
                    }
                    else if (getAmount() < getTotal())
                    {
                        MessageBox.Show("Solde insuffisant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        orders_montant.Text = "";
                        orders_change.Text = "";

                    }
                    else
                    {
                        orders_change.Text = getChange().ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Non valide !" + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orders_montant.Text = "";
                    orders_change.Text = "";
                }
            }
        }

        private void orders_payBtn_Click(object sender, EventArgs e)
        {
            if (orders_montant.Text == "" || dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Erreur de payment !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (getTotal() == 0)
            {
                MessageBox.Show("Commande déja payée !", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (getAmount() < getTotal())
            {
                MessageBox.Show("Solde insuffisant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orders_montant.Text = "";
                orders_change.Text = "";

            }
            else
            {
                if (MessageBox.Show("Voulez vous payer ?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();


                        int idClient = generateID();
                        string getLatestOrder = "SELECT TOP 1 id FROM orders WHERE idClient = @idClient ORDER BY id DESC";
                        int latestOrderId = 0;

                        using (SqlCommand getLatestCmd = new SqlCommand(getLatestOrder, conn))
                        {
                            getLatestCmd.Parameters.AddWithValue("@idClient", idClient);
                            latestOrderId = Convert.ToInt32(getLatestCmd.ExecuteScalar());
                        }

                        string insertTransaction = "INSERT INTO transactions (idClient, order_id,caissier_id, prixTotal, statut, dateTransaction) VALUES (@idClient, @order_id,@caissier_id, @prixTotal, @statut, @dateTransaction)";
                        using (SqlCommand insertTransactionCmd = new SqlCommand(insertTransaction, conn))
                        {
                            insertTransactionCmd.Parameters.AddWithValue("@idClient", idClient);
                            insertTransactionCmd.Parameters.AddWithValue("@order_id", latestOrderId);
                            insertTransactionCmd.Parameters.AddWithValue("@caissier_id", UserSession.UserId);
                            insertTransactionCmd.Parameters.AddWithValue("@prixTotal", orders_totalPrice.Text.Trim());
                            insertTransactionCmd.Parameters.AddWithValue("@statut", "Completed");
                            insertTransactionCmd.Parameters.AddWithValue("@dateTransaction", DateTime.Today);

                            insertTransactionCmd.ExecuteNonQuery();
                        }

                        string updateOrder = "UPDATE orders SET statut ='Completed' WHERE idClient = @idClient";
                        using (SqlCommand updateOrderCmd = new SqlCommand(updateOrder, conn))
                        {
                            updateOrderCmd.Parameters.AddWithValue("@idClient", idClient);
                            updateOrderCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Commande payée avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayTotal();
        }

        private void orders_removeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer la commande ID : " + getOrderID + " ? ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getOrderID != 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteCommande = "DELETE FROM orders WHERE id = " + getOrderID;
                        using (SqlCommand deleteCommandeCmd = new SqlCommand(deleteCommande, conn))
                        {
                            deleteCommandeCmd.ExecuteNonQuery();
                            MessageBox.Show("Commande supprimée avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selectionner d'abord une commande", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            displayAllOrders();
            displayTotal();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private int getOrderID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getOrderID = Convert.ToInt32(row.Cells[0].Value);

            }
        }

        private void orders_recieptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float totalPrice = getTotal();
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int tableMargin = 20;
            int headerMargin = 10;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Bakery World";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;
            string[] header = { "Id", "idClient", "idCaissier", "Prix", "Quantité" };
            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;
            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;
                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                int labelMargin = (int)Math.Min(rSpace, 200);
                DateTime today = DateTime.Now;
                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-----------------------------------", labelFont).Width;
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Prix Total : \tDhs" + totalPrice + "\nMontant : \tDhs" + getAmount() + "\n\t\t-----------\nReste : \tDhs" + getChange(), labelFont, Brushes.Black, labelX, y);
                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("-----------------------------------", labelFont).Width, y);
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
}
