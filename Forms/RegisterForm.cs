using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace GestionDeVente
{
    public partial class RegisterForm : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void regiBtn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_confirmPass.Text == "")
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
                        checkUsernameCmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsernameCmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string existUser = register_username.Text.Substring(0, 1).Trim() + register_username.Text.Substring(1);
                            MessageBox.Show(existUser + " déja existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register_password.Text.Length < 8)
                        {
                            MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (register_password.Text != register_confirmPass.Text)
                        {
                            MessageBox.Show("Les mots de passes ne sont pas identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string hashedPassword = HashPassword(register_password.Text.Trim());
                            string insertUser = "INSERT INTO users (username,password,role,status,date_register) VALUES (@username,@pass,@role,@status,@date)";
                            using (SqlCommand insertUserCmd = new SqlCommand(insertUser, conn))
                            {

                                insertUserCmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                insertUserCmd.Parameters.AddWithValue("@pass", hashedPassword);
                                insertUserCmd.Parameters.AddWithValue("@role", "Caissier");
                                insertUserCmd.Parameters.AddWithValue("@status", "Approval");
                                DateTime today = DateTime.Today;
                                insertUserCmd.Parameters.AddWithValue("@date", today);
                                insertUserCmd.ExecuteNonQuery();
                                MessageBox.Show("Compte crée avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginForm form1 = new LoginForm();
                                form1.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void regLogBtn_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged_1(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_confirmPass.PasswordChar = register_showPass.Checked ? '\0' : '*';

        }
    }
}
