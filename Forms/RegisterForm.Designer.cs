namespace GestionDeVente
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_username = new MaterialSkin.Controls.MaterialTextBox2();
            this.register_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.register_confirmPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.register_showPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.regiBtn = new MaterialSkin.Controls.MaterialButton();
            this.regLogBtn = new MaterialSkin.Controls.MaterialButton();
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
            this.panel1.Size = new System.Drawing.Size(406, 594);
            this.panel1.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vous avez un compte ? ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(443, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(443, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(447, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirmer le mot de passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // register_username
            // 
            this.register_username.AnimateReadOnly = false;
            this.register_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.register_username.Depth = 0;
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.register_username.HideSelection = true;
            this.register_username.LeadingIcon = null;
            this.register_username.Location = new System.Drawing.Point(447, 69);
            this.register_username.MaxLength = 32767;
            this.register_username.MouseState = MaterialSkin.MouseState.OUT;
            this.register_username.Name = "register_username";
            this.register_username.PasswordChar = '\0';
            this.register_username.PrefixSuffixText = null;
            this.register_username.ReadOnly = false;
            this.register_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.register_username.SelectedText = "";
            this.register_username.SelectionLength = 0;
            this.register_username.SelectionStart = 0;
            this.register_username.ShortcutsEnabled = true;
            this.register_username.Size = new System.Drawing.Size(366, 48);
            this.register_username.TabIndex = 19;
            this.register_username.TabStop = false;
            this.register_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.register_username.TrailingIcon = null;
            this.register_username.UseSystemPasswordChar = false;
            // 
            // register_password
            // 
            this.register_password.AnimateReadOnly = false;
            this.register_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.register_password.Depth = 0;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.register_password.HideSelection = true;
            this.register_password.LeadingIcon = null;
            this.register_password.Location = new System.Drawing.Point(447, 171);
            this.register_password.MaxLength = 32767;
            this.register_password.MouseState = MaterialSkin.MouseState.OUT;
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.PrefixSuffixText = null;
            this.register_password.ReadOnly = false;
            this.register_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.register_password.SelectedText = "";
            this.register_password.SelectionLength = 0;
            this.register_password.SelectionStart = 0;
            this.register_password.ShortcutsEnabled = true;
            this.register_password.Size = new System.Drawing.Size(366, 48);
            this.register_password.TabIndex = 20;
            this.register_password.TabStop = false;
            this.register_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.register_password.TrailingIcon = null;
            this.register_password.UseSystemPasswordChar = false;
            // 
            // register_confirmPass
            // 
            this.register_confirmPass.AnimateReadOnly = false;
            this.register_confirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_confirmPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.register_confirmPass.Depth = 0;
            this.register_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.register_confirmPass.HideSelection = true;
            this.register_confirmPass.LeadingIcon = null;
            this.register_confirmPass.Location = new System.Drawing.Point(451, 284);
            this.register_confirmPass.MaxLength = 32767;
            this.register_confirmPass.MouseState = MaterialSkin.MouseState.OUT;
            this.register_confirmPass.Name = "register_confirmPass";
            this.register_confirmPass.PasswordChar = '*';
            this.register_confirmPass.PrefixSuffixText = null;
            this.register_confirmPass.ReadOnly = false;
            this.register_confirmPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.register_confirmPass.SelectedText = "";
            this.register_confirmPass.SelectionLength = 0;
            this.register_confirmPass.SelectionStart = 0;
            this.register_confirmPass.ShortcutsEnabled = true;
            this.register_confirmPass.Size = new System.Drawing.Size(362, 48);
            this.register_confirmPass.TabIndex = 21;
            this.register_confirmPass.TabStop = false;
            this.register_confirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.register_confirmPass.TrailingIcon = null;
            this.register_confirmPass.UseSystemPasswordChar = false;
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Depth = 0;
            this.register_showPass.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.register_showPass.Location = new System.Drawing.Point(451, 359);
            this.register_showPass.Margin = new System.Windows.Forms.Padding(0);
            this.register_showPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.register_showPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.ReadOnly = false;
            this.register_showPass.Ripple = true;
            this.register_showPass.Size = new System.Drawing.Size(189, 37);
            this.register_showPass.TabIndex = 22;
            this.register_showPass.Text = "Montrer mot de passe";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged_1);
            // 
            // regiBtn
            // 
            this.regiBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regiBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regiBtn.Depth = 0;
            this.regiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.regiBtn.HighEmphasis = true;
            this.regiBtn.Icon = null;
            this.regiBtn.Location = new System.Drawing.Point(548, 421);
            this.regiBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regiBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.regiBtn.Name = "regiBtn";
            this.regiBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regiBtn.Size = new System.Drawing.Size(129, 36);
            this.regiBtn.TabIndex = 23;
            this.regiBtn.Text = "Créer compte";
            this.regiBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.regiBtn.UseAccentColor = false;
            this.regiBtn.UseVisualStyleBackColor = true;
            this.regiBtn.Click += new System.EventHandler(this.regiBtn_Click);
            // 
            // regLogBtn
            // 
            this.regLogBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regLogBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regLogBtn.Depth = 0;
            this.regLogBtn.HighEmphasis = true;
            this.regLogBtn.Icon = null;
            this.regLogBtn.Location = new System.Drawing.Point(561, 531);
            this.regLogBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regLogBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.regLogBtn.Name = "regLogBtn";
            this.regLogBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regLogBtn.Size = new System.Drawing.Size(105, 36);
            this.regLogBtn.TabIndex = 24;
            this.regLogBtn.Text = "Connexion";
            this.regLogBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.regLogBtn.UseAccentColor = true;
            this.regLogBtn.UseVisualStyleBackColor = true;
            this.regLogBtn.Click += new System.EventHandler(this.regLogBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 594);
            this.Controls.Add(this.regLogBtn);
            this.Controls.Add(this.regiBtn);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_confirmPass);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerForm";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Label label3;
        
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 register_username;
        private MaterialSkin.Controls.MaterialTextBox2 register_password;
        private MaterialSkin.Controls.MaterialTextBox2 register_confirmPass;
        private MaterialSkin.Controls.MaterialCheckbox register_showPass;
        private MaterialSkin.Controls.MaterialButton regiBtn;
        private MaterialSkin.Controls.MaterialButton regLogBtn;
    }
}