using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GestionDeVente
{
    public partial class LoginForm : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {

            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Entrer tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    string checkUser = "SELECT * FROM users WHERE username = @username AND status = 'Active'";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUser, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUserCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {

                            MessageBox.Show("Utilisateur n'existe pas ou est inactif !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        DataRow row = table.Rows[0];
                        string role = row["role"].ToString();
                        string storedHashedPassword = table.Rows[0]["password"].ToString();
                        int userId = Convert.ToInt32(row["id"]);
                        Debug.WriteLine($"Stored Hashed Password: {storedHashedPassword}");


                        if (VerifyPassword(login_password.Text.Trim(), storedHashedPassword))
                        {
                            MessageBox.Show("Connexion réussie !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserSession.Username = login_username.Text.Trim();
                            UserSession.Role = role;
                            UserSession.UserId = userId;
                            if (role == "Admin")
                            {
                                AdminForm mainForm = new AdminForm();
                                mainForm.Show();
                                this.Hide();
                            }

                            else if (role == "Caissier")
                            {
                                CaissierForm caissierForm = new CaissierForm();
                                caissierForm.Show();
                                this.Hide();
                            }


                        }
                        else
                        {

                            MessageBox.Show("Mot de passe incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

            }
        }

        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                string hashedEnteredPassword = builder.ToString();
                Debug.WriteLine($"Entered Hashed Password: {hashedEnteredPassword}");
                return hashedEnteredPassword == storedHashedPassword;
            }
        }
    }
}
