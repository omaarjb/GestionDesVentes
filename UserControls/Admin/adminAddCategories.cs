using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GestionDeVente
{
    public partial class adminAddCategories : UserControl
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public adminAddCategories()
        {
            InitializeComponent();
            displayAddCategories();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddCategories();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void clearFields()
        {
            addCategories_category.Text = "";
            addCategories_status.SelectedIndex = -1;

        }

        public void displayAddCategories()
        {
            Categorie adminAddCategoriesData = new Categorie();
            List<Categorie> listData = adminAddCategoriesData.listAddCategoriesData();
            dataGridView1.DataSource = listData;

        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkCategory = "SELECT * FROM categories WHERE category = @category";
                    using (SqlCommand checkCategoryCmd = new SqlCommand(checkCategory, conn))
                    {
                        checkCategoryCmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkCategoryCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string existCategory = addCategories_category.Text.Substring(0, 1).Trim() + addCategories_category.Text.Substring(1);
                            MessageBox.Show(existCategory + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {

                            string insertCategory = "INSERT INTO categories (category,status,date_created) VALUES (@category,@status,@date_created)";
                            using (SqlCommand insertCategoryCmd = new SqlCommand(insertCategory, conn))
                            {

                                insertCategoryCmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());

                                insertCategoryCmd.Parameters.AddWithValue("@status", addCategories_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                insertCategoryCmd.Parameters.AddWithValue("@date_created", today);
                                insertCategoryCmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Catégorie ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                displayAddCategories();
            }
        }

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string getCurrentUsername = "SELECT category FROM categories WHERE id = @id";
                    string currentCategory = "";

                    using (SqlCommand getCurrentCmd = new SqlCommand(getCurrentUsername, conn))
                    {
                        getCurrentCmd.Parameters.AddWithValue("@id", getID);
                        currentCategory = Convert.ToString(getCurrentCmd.ExecuteScalar());
                    }


                    bool canProceed = true;
                    if (currentCategory != addCategories_category.Text.Trim())
                    {
                        string checkCategory = "SELECT * FROM categories WHERE category = @category";
                        using (SqlCommand checkCategoryCmd = new SqlCommand(checkCategory, conn))
                        {
                            checkCategoryCmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkCategoryCmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string existUser = addCategories_category.Text.Substring(0, 1).Trim() + addCategories_category.Text.Substring(1);
                                MessageBox.Show(existUser + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                canProceed = false;
                            }
                        }
                    }

                    if (canProceed)
                    {
                        string updateUser = "UPDATE categories SET category = @category, status = @status WHERE id = @id";
                        using (SqlCommand updateUserCmd = new SqlCommand(updateUser, conn))
                        {
                            updateUserCmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                            updateUserCmd.Parameters.AddWithValue("@status", addCategories_status.SelectedItem.ToString());
                            updateUserCmd.Parameters.AddWithValue("@id", getID);

                            updateUserCmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Catégorie modifié avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                displayAddCategories();
            }
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                addCategories_category.Text = row.Cells[1].Value.ToString();
                addCategories_status.SelectedItem = row.Cells[2].Value.ToString();
            }
        }

        private void addCategories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Selectionner la catégorie à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Voulez vous supprimer cet catégorie ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string deleteCategory = "DELETE FROM categories WHERE id = @id";
                        using (SqlCommand deleteCategoryCmd = new SqlCommand(deleteCategory, conn))
                        {
                            deleteCategoryCmd.Parameters.AddWithValue("@id", getID);
                            deleteCategoryCmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Catégorie supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    displayAddCategories();
                }

            }
        }
    }
}
