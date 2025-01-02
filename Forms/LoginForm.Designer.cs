namespace GestionDeVente
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new MaterialSkin.Controls.MaterialTextBox2();
            this.login_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.lgnBtn = new MaterialSkin.Controls.MaterialButton();
            this.regBtn = new MaterialSkin.Controls.MaterialButton();
            this.logPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 523);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-52, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(445, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(445, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(491, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vous avez pas de compte ? ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_username
            // 
            this.login_username.AnimateReadOnly = false;
            this.login_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.login_username.Depth = 0;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.login_username.HideSelection = true;
            this.login_username.LeadingIcon = null;
            this.login_username.Location = new System.Drawing.Point(449, 124);
            this.login_username.MaxLength = 32767;
            this.login_username.MouseState = MaterialSkin.MouseState.OUT;
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.PrefixSuffixText = null;
            this.login_username.ReadOnly = false;
            this.login_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_username.SelectedText = "";
            this.login_username.SelectionLength = 0;
            this.login_username.SelectionStart = 0;
            this.login_username.ShortcutsEnabled = true;
            this.login_username.Size = new System.Drawing.Size(316, 48);
            this.login_username.TabIndex = 8;
            this.login_username.TabStop = false;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_username.TrailingIcon = null;
            this.login_username.UseSystemPasswordChar = false;
            // 
            // login_password
            // 
            this.login_password.AnimateReadOnly = false;
            this.login_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.login_password.Depth = 0;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.login_password.HideSelection = true;
            this.login_password.LeadingIcon = null;
            this.login_password.Location = new System.Drawing.Point(449, 228);
            this.login_password.MaxLength = 32767;
            this.login_password.MouseState = MaterialSkin.MouseState.OUT;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.PrefixSuffixText = null;
            this.login_password.ReadOnly = false;
            this.login_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_password.SelectedText = "";
            this.login_password.SelectionLength = 0;
            this.login_password.SelectionStart = 0;
            this.login_password.ShortcutsEnabled = true;
            this.login_password.Size = new System.Drawing.Size(316, 48);
            this.login_password.TabIndex = 9;
            this.login_password.TabStop = false;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_password.TrailingIcon = null;
            this.login_password.UseSystemPasswordChar = false;
            // 
            // lgnBtn
            // 
            this.lgnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lgnBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lgnBtn.Depth = 0;
            this.lgnBtn.HighEmphasis = true;
            this.lgnBtn.Icon = null;
            this.lgnBtn.Location = new System.Drawing.Point(531, 356);
            this.lgnBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lgnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lgnBtn.Size = new System.Drawing.Size(105, 36);
            this.lgnBtn.TabIndex = 10;
            this.lgnBtn.Text = "Connexion";
            this.lgnBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lgnBtn.UseAccentColor = false;
            this.lgnBtn.UseVisualStyleBackColor = true;
            this.lgnBtn.Click += new System.EventHandler(this.lgnBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regBtn.Depth = 0;
            this.regBtn.HighEmphasis = true;
            this.regBtn.Icon = null;
            this.regBtn.Location = new System.Drawing.Point(507, 458);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.regBtn.Name = "regBtn";
            this.regBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regBtn.Size = new System.Drawing.Size(153, 36);
            this.regBtn.TabIndex = 11;
            this.regBtn.Text = "Créer un compte";
            this.regBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.regBtn.UseAccentColor = true;
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // logPass
            // 
            this.logPass.AutoSize = true;
            this.logPass.Depth = 0;
            this.logPass.Location = new System.Drawing.Point(449, 296);
            this.logPass.Margin = new System.Windows.Forms.Padding(0);
            this.logPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.logPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.logPass.Name = "logPass";
            this.logPass.ReadOnly = false;
            this.logPass.Ripple = true;
            this.logPass.Size = new System.Drawing.Size(189, 37);
            this.logPass.TabIndex = 12;
            this.logPass.Text = "Montrer mot de passe";
            this.logPass.UseVisualStyleBackColor = true;
            this.logPass.CheckedChanged += new System.EventHandler(this.logPass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(821, 523);
            this.Controls.Add(this.logPass);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.lgnBtn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 login_username;
        private MaterialSkin.Controls.MaterialTextBox2 login_password;
        private MaterialSkin.Controls.MaterialButton lgnBtn;
        private MaterialSkin.Controls.MaterialButton regBtn;
        private MaterialSkin.Controls.MaterialCheckbox logPass;
    }
}