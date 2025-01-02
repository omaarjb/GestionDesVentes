using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GestionDeVente
{
    public partial class adminAddProducts : UserControl
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public adminAddProducts()
        {
            InitializeComponent();
            displayProducts();
            displayCategories();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayProducts();
            displayCategories();
        }
        public void displayCategories()
        {
            addProducts_category.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectedCategories = "SELECT * FROM categories WHERE status = 'Active' ";
                using (SqlCommand selectedCategoriescmd = new SqlCommand(selectedCategories, conn))
                {
                    SqlDataReader reader = selectedCategoriescmd.ExecuteReader();
                    while (reader.Read())
                    {
                        addProducts_category.Items.Add(reader["category"]);
                    }
                }
            }
        }

        private void addProducts_importBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodName.Text == "" || addProducts_prodId.Text == "" || addProducts_price.Text == "" || addProducts_price.Text == "" || addProducts_status.SelectedIndex == -1 || addProducts_category.SelectedIndex == -1)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkProdId = "SELECT * FROM produits WHERE idProd = @prodId";
                    using (SqlCommand checkProdIdCmd = new SqlCommand(checkProdId, conn))
                    {
                        checkProdIdCmd.Parameters.AddWithValue("@prodId", addProducts_prodId.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdIdCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string existProdId = addProducts_prodId.Text.Substring(0, 1).Trim() + addProducts_prodId.Text.Substring(1);
                            MessageBox.Show(existProdId + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string insertProd = "INSERT INTO produits (idProd,nom,categorie,prix,stock,statut,date_ajout,image) VALUES (@idProd,@nom,@categorie,@prix,@stock,@statut,@date_ajout,@image)";
                            string relativePath = Path.Combine("produits", addProducts_prodId.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);
                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(addProducts_imageView.ImageLocation, path, true);

                            using (SqlCommand insertProdCmd = new SqlCommand(insertProd, conn))
                            {
                                insertProdCmd.Parameters.AddWithValue("@idProd", addProducts_prodId.Text.Trim());
                                insertProdCmd.Parameters.AddWithValue("@nom", addProducts_prodName.Text.Trim());
                                insertProdCmd.Parameters.AddWithValue("@categorie", addProducts_category.SelectedItem.ToString());
                                insertProdCmd.Parameters.AddWithValue("@prix", addProducts_price.Text.Trim());
                                insertProdCmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                insertProdCmd.Parameters.AddWithValue("@statut", addProducts_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                insertProdCmd.Parameters.AddWithValue("@date_ajout", today);
                                insertProdCmd.Parameters.AddWithValue("@image", path);

                                insertProdCmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Produit ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                    }
                }
                displayProducts();
            }


        }
        public void clearFields()
        {
            addProducts_prodId.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;

        }

        public void displayProducts()
        {
            Produits adminAddProductsData = new Produits();
            List<Produits> listData = adminAddProductsData.listAddProductsData();
            dataGridView1.DataSource = listData;

        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodName.Text == "" || addProducts_prodId.Text == "" || addProducts_price.Text == "" || addProducts_price.Text == "" || addProducts_status.SelectedIndex == -1 || addProducts_category.SelectedIndex == -1 || addProducts_imageView.Image == null)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string getCurrentProduct = "SELECT idProd FROM produits WHERE id = @id";
                    string currentProduct = "";

                    using (SqlCommand getCurrentProductCmd = new SqlCommand(getCurrentProduct, conn))
                    {
                        getCurrentProductCmd.Parameters.AddWithValue("@id", getID);
                        currentProduct = Convert.ToString(getCurrentProductCmd.ExecuteScalar());
                    }


                    bool canProceed = true;
                    if (currentProduct != addProducts_prodId.Text.Trim())
                    {
                        string checkProduct = "SELECT * FROM produits WHERE idProd = @prodId";
                        using (SqlCommand checkProductCmd = new SqlCommand(checkProduct, conn))
                        {
                            checkProductCmd.Parameters.AddWithValue("@prodId", addProducts_prodId.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkProductCmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string existProduct = addProducts_prodId.Text.Substring(0, 1).Trim() + addProducts_prodId.Text.Substring(1);
                                MessageBox.Show(existProduct + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                canProceed = false;
                            }
                        }
                    }

                    if (canProceed)
                    {
                        if (MessageBox.Show("Voulez vous modifier le produit : " + addProducts_prodId.Text.Trim() + "?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string updateProduct = "UPDATE produits SET idProd=@prodId,nom=@nom ,categorie=@category, prix=@price, stock=@stock, statut=@status  WHERE id = @id";
                            using (SqlCommand updateProductCmd = new SqlCommand(updateProduct, conn))
                            {
                                updateProductCmd.Parameters.AddWithValue("@prodId", addProducts_prodId.Text.Trim());
                                updateProductCmd.Parameters.AddWithValue("@nom", addProducts_prodName.Text.Trim());
                                updateProductCmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                updateProductCmd.Parameters.AddWithValue("@category", addProducts_category.SelectedItem.ToString());
                                updateProductCmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                updateProductCmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                                updateProductCmd.Parameters.AddWithValue("@id", getID);
                                updateProductCmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Produit modifié avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                    }
                }

                displayProducts();
            }
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                addProducts_prodId.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_status.SelectedItem = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[8].Value.ToString();
                try
                {
                    if (imagePath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur ssss: " + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodName.Text == "" || addProducts_prodId.Text == "" || addProducts_price.Text == "" || addProducts_price.Text == "" || addProducts_status.SelectedIndex == -1 || addProducts_category.SelectedIndex == -1 || addProducts_imageView.Image == null)
            {
                MessageBox.Show("Sélectionner le produit à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Voulez vous supprimer le produit ID : " + addProducts_prodId.Text.Trim() + " ? ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string deleteProduct = "DELETE FROM produits WHERE id = @id";
                        using (SqlCommand deleteProductCmd = new SqlCommand(deleteProduct, conn))
                        {
                            deleteProductCmd.Parameters.AddWithValue("@id", getID);
                            deleteProductCmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Produit supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    displayProducts();
                }

            }
        }
    }

}
