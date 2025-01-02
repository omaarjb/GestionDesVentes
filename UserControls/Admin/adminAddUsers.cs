using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class adminAddUsers : UserControl
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public adminAddUsers()
        {
            InitializeComponent();
            displayAddUsers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void displayAddUsers()
        {
            Utilisateur adminAddUsersData = new Utilisateur();
            List<Utilisateur> listData = adminAddUsersData.listAddUsersData();
            dataGridView1.DataSource = listData;

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsers();
        }



        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_ConfirmPassword.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @username";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsername, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsernameCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string existUser = addUsers_username.Text.Substring(0, 1).Trim() + addUsers_username.Text.Substring(1);
                            MessageBox.Show(existUser + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUsers_password.Text.Length < 8)
                        {
                            MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (addUsers_password.Text != addUsers_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Les mots de passes ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string hashedPassword = registerForm.HashPassword(addUsers_password.Text.Trim());
                            string insertUser = "INSERT INTO users (username,password,role,status,date_register) VALUES (@username,@pass,@role,@status,@date)";
                            using (SqlCommand insertUserCmd = new SqlCommand(insertUser, conn))
                            {

                                insertUserCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                                insertUserCmd.Parameters.AddWithValue("@pass", hashedPassword);
                                insertUserCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                insertUserCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                insertUserCmd.Parameters.AddWithValue("@date", today);
                                insertUserCmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Utilisateur ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
            displayAddUsers();
        }

        RegisterForm registerForm = new RegisterForm();

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_ConfirmPassword.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;

        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_ConfirmPassword.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string getCurrentUsername = "SELECT username FROM users WHERE id = @id";
                    string currentUsername = "";

                    using (SqlCommand getCurrentCmd = new SqlCommand(getCurrentUsername, conn))
                    {
                        getCurrentCmd.Parameters.AddWithValue("@id", getID);
                        currentUsername = Convert.ToString(getCurrentCmd.ExecuteScalar());
                    }


                    bool canProceed = true;
                    if (currentUsername != addUsers_username.Text.Trim())
                    {
                        string checkUsername = "SELECT * FROM users WHERE username = @username";
                        using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsername, conn))
                        {
                            checkUsernameCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsernameCmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string existUser = addUsers_username.Text.Substring(0, 1).Trim() + addUsers_username.Text.Substring(1);
                                MessageBox.Show(existUser + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                canProceed = false;
                            }
                        }
                    }

                    if (canProceed)
                    {
                        if (addUsers_password.Text.Length < 8)
                        {
                            MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUsers_password.Text != addUsers_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Les mots de passes ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string hashedPassword = registerForm.HashPassword(addUsers_password.Text.Trim());
                            string updateUser = "UPDATE users SET username = @username, password = @pass, role = @role, status = @status WHERE id = @id";
                            using (SqlCommand updateUserCmd = new SqlCommand(updateUser, conn))
                            {
                                updateUserCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                                updateUserCmd.Parameters.AddWithValue("@pass", hashedPassword);
                                updateUserCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                updateUserCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                updateUserCmd.Parameters.AddWithValue("@id", getID);

                                updateUserCmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Utilisateur modifié avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                displayAddUsers();
            }
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void addUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Selectionner l'utilisateur à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Voulez vous supprimer cet utlisateur ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string deleteUser = "DELETE FROM users WHERE id = @id";
                        using (SqlCommand deleteUserCmd = new SqlCommand(deleteUser, conn))
                        {
                            deleteUserCmd.Parameters.AddWithValue("@id", getID);
                            deleteUserCmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Utilisateur supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    displayAddUsers();
                }

            }
        }
    }
}