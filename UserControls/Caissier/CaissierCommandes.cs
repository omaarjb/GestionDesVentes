using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data.SqlClient;
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
            orders_category.SelectedIndex = -1;
            orders_prodName.Text = ".....";
            orders_price.Text = ".....";
            orders_quantity.Value = 0;
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




        private void addOrdBtn_Click(object sender, EventArgs e)
        {
            if (orders_category.SelectedIndex == -1 || orders_category.SelectedIndex == -1 || orders_prodName.Text == "" || orders_price.Text == "" || orders_quantity.Value == 0)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertData = "INSERT INTO orders (idClient,prix, quantite, statut, dateCommande, caissierid,prodName) " +
                                "VALUES (@idClient, @prix, @quantite, @statut, @dateCommande, @caissierid,@prodName)";
                    using (SqlCommand insertDatacmd = new SqlCommand(insertData, conn))
                    {
                        insertDatacmd.Parameters.AddWithValue("@idClient", generateID());
                        insertDatacmd.Parameters.AddWithValue("@prix", orders_price.Text.Trim());
                        insertDatacmd.Parameters.AddWithValue("@quantite", orders_quantity.Value);
                        insertDatacmd.Parameters.AddWithValue("@statut", "Pending");
                        DateTime today = DateTime.Today;
                        insertDatacmd.Parameters.AddWithValue("@dateCommande", today);
                        insertDatacmd.Parameters.AddWithValue("@caissierId", UserSession.UserId);
                        insertDatacmd.Parameters.AddWithValue("@prodName", orders_prodName.Text.Trim());


                        insertDatacmd.ExecuteNonQuery();
                        MessageBox.Show("Commande ajoutée avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayAllOrders();
            displayTotal();
        }

        private void clearOrdBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ordPayBtn_Click(object sender, EventArgs e)
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

                        string insertTransaction = @"
                        INSERT INTO transactions 
                        (idClient, order_id, caissier_id, product_id, prixTotal, statut, dateTransaction) 
                        VALUES 
                        (@idClient, @order_id, @caissier_id, @product_id, @prixTotal, @statut, @dateTransaction)";

                        using (SqlCommand insertTransactionCmd = new SqlCommand(insertTransaction, conn))
                        {
                            insertTransactionCmd.Parameters.AddWithValue("@idClient", idClient);
                            insertTransactionCmd.Parameters.AddWithValue("@order_id", latestOrderId);
                            insertTransactionCmd.Parameters.AddWithValue("@caissier_id", UserSession.UserId);
                            insertTransactionCmd.Parameters.AddWithValue("@product_id", orders_prodId.SelectedItem.ToString());
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

        private void ordReceipBtn_Click(object sender, EventArgs e)
        {
            string pdfPath = "Facture.pdf";
            string logoPath = "C:\\Users\\omarj\\OneDrive\\Desktop\\images .net\\logo.jpg";


            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);


                    ImageData imageData = ImageDataFactory.Create(logoPath);
                    Image logo = new Image(imageData)
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                        .SetMaxWidth(100); // Adjust width if needed
                    document.Add(logo);


                    PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont italicFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE);


                    document.Add(new Paragraph("Boulangerie Patisserie")
                        .SetFont(boldFont)
                        .SetFontSize(24)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(5));


                    document.Add(new Paragraph("Votre Meilleur Choix")
                        .SetFont(italicFont)
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(20)
                        .SetFontColor(ColorConstants.GRAY));


                    LineSeparator line = new LineSeparator(new SolidLine(1f));
                    document.Add(line.SetMarginBottom(20));


                    float[] columnWidths = { 1, 2, 2, 2, 2, 2 };
                    Table table = new Table(columnWidths)
                        .UseAllAvailableWidth()
                        .SetMarginBottom(20);

                    string[] headers = { "N° Commande", "N° Client", "N° Caissier", "Prix", "Quantité", "Produit" };


                    foreach (string header in headers)
                    {
                        table.AddHeaderCell(new Cell()
                            .Add(new Paragraph(header)
                            .SetFont(boldFont)
                            .SetFontSize(11))
                            .SetBackgroundColor(new DeviceRgb(240, 240, 240))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetPadding(8));
                    }


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            object cellValue = row.Cells[i].Value;
                            string cellText;


                            if (i == 3 && cellValue != null)
                            {
                                cellText = $"{cellValue:F2} Dhs";
                            }
                            else
                            {
                                cellText = cellValue != null ? cellValue.ToString() : string.Empty;
                            }

                            table.AddCell(new Cell()
                                .Add(new Paragraph(cellText)
                                .SetFont(font)
                                .SetFontSize(10))
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetPadding(8));
                        }
                    }

                    document.Add(table);


                    document.Add(line.SetMarginBottom(20));


                    Table priceTable = new Table(2).UseAllAvailableWidth();

                    float totalPrice = getTotal();
                    float amountPaid = getAmount();
                    float change = getChange();


                    AddPriceRow(priceTable, "Prix Total:", totalPrice, font, boldFont);
                    AddPriceRow(priceTable, "Montant Payé:", amountPaid, font, boldFont);
                    AddPriceRow(priceTable, "Reste:", change, font, boldFont);

                    document.Add(priceTable.SetMarginBottom(20));


                    document.Add(new Paragraph("Merci pour votre visite!")
                        .SetFont(boldFont)
                        .SetFontSize(14)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginBottom(10));


                    document.Add(new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetFont(font)
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFontColor(ColorConstants.GRAY));

                    document.Close();
                }
            }

            MessageBox.Show("PDF generated successfully at: " + pdfPath, "PDF Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(pdfPath);
        }

        private void AddPriceRow(Table table, string label, float amount, PdfFont font, PdfFont boldFont)
        {
            table.AddCell(new Cell()
                .Add(new Paragraph(label)
                .SetFont(font)
                .SetFontSize(12))
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT));

            table.AddCell(new Cell()
                .Add(new Paragraph($"{amount:F2} Dhs")
                .SetFont(boldFont)
                .SetFontSize(12))
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT));
        }

        private void delOrdBtn_Click(object sender, EventArgs e)
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









        private void orders_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            orders_prodName.Text = "";
            orders_price.Text = "";
            orders_quantity.Value = 0;


            orders_prodId.Items.Clear();
            orders_prodId.SelectedIndex = -1;

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

        private void orders_prodId_SelectedIndexChanged(object sender, EventArgs e)
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



        private void orders_montant_KeyDown_2(object sender, KeyEventArgs e)
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
    }
}
