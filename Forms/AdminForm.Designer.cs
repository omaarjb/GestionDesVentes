namespace GestionDeVente
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.histBtn = new MaterialSkin.Controls.MaterialButton();
            this.catBtn = new MaterialSkin.Controls.MaterialButton();
            this.productBtn = new MaterialSkin.Controls.MaterialButton();
            this.usersBtn = new MaterialSkin.Controls.MaterialButton();
            this.dashboard_btn = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcomeAdmin = new System.Windows.Forms.Label();
            this.decBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new GestionDeVente.adminDashboard();
            this.adminAddUsers1 = new GestionDeVente.adminAddUsers();
            this.adminAddProducts1 = new GestionDeVente.adminAddProducts();
            this.adminAddCategories1 = new GestionDeVente.adminAddCategories();
            this.adminHistorique1 = new GestionDeVente.adminHistorique();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.histBtn);
            this.panel1.Controls.Add(this.catBtn);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.welcomeAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 166);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // histBtn
            // 
            this.histBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.histBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.histBtn.Depth = 0;
            this.histBtn.HighEmphasis = true;
            this.histBtn.Icon = null;
            this.histBtn.Location = new System.Drawing.Point(946, 86);
            this.histBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.histBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.histBtn.Name = "histBtn";
            this.histBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.histBtn.Size = new System.Drawing.Size(106, 36);
            this.histBtn.TabIndex = 11;
            this.histBtn.Text = "Historique";
            this.histBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.histBtn.UseAccentColor = false;
            this.histBtn.UseVisualStyleBackColor = true;
            this.histBtn.Click += new System.EventHandler(this.histBtn_Click_1);
            // 
            // catBtn
            // 
            this.catBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.catBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.catBtn.Depth = 0;
            this.catBtn.HighEmphasis = true;
            this.catBtn.Icon = null;
            this.catBtn.Location = new System.Drawing.Point(704, 86);
            this.catBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.catBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.catBtn.Name = "catBtn";
            this.catBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.catBtn.Size = new System.Drawing.Size(138, 36);
            this.catBtn.TabIndex = 10;
            this.catBtn.Text = "Les catégories";
            this.catBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.catBtn.UseAccentColor = false;
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click_1);
            // 
            // productBtn
            // 
            this.productBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.productBtn.Depth = 0;
            this.productBtn.HighEmphasis = true;
            this.productBtn.Icon = null;
            this.productBtn.Location = new System.Drawing.Point(476, 86);
            this.productBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.productBtn.Name = "productBtn";
            this.productBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.productBtn.Size = new System.Drawing.Size(120, 36);
            this.productBtn.TabIndex = 9;
            this.productBtn.Text = "les produits";
            this.productBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productBtn.UseAccentColor = false;
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click_1);
            // 
            // usersBtn
            // 
            this.usersBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usersBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.usersBtn.Depth = 0;
            this.usersBtn.HighEmphasis = true;
            this.usersBtn.Icon = null;
            this.usersBtn.Location = new System.Drawing.Point(223, 86);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usersBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.usersBtn.Size = new System.Drawing.Size(149, 36);
            this.usersBtn.TabIndex = 8;
            this.usersBtn.Text = "Les Utilisateurs";
            this.usersBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.usersBtn.UseAccentColor = false;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click_1);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashboard_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dashboard_btn.Depth = 0;
            this.dashboard_btn.HighEmphasis = true;
            this.dashboard_btn.Icon = null;
            this.dashboard_btn.Location = new System.Drawing.Point(36, 86);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dashboard_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dashboard_btn.Size = new System.Drawing.Size(108, 36);
            this.dashboard_btn.TabIndex = 7;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dashboard_btn.UseAccentColor = false;
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 340);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 474);
            this.panel2.TabIndex = 1;
            // 
            // welcomeAdmin
            // 
            this.welcomeAdmin.AutoSize = true;
            this.welcomeAdmin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeAdmin.Location = new System.Drawing.Point(560, 15);
            this.welcomeAdmin.Name = "welcomeAdmin";
            this.welcomeAdmin.Size = new System.Drawing.Size(114, 29);
            this.welcomeAdmin.TabIndex = 0;
            this.welcomeAdmin.Text = "Bienvenue ";
            this.welcomeAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // decBtn
            // 
            this.decBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.decBtn.Depth = 0;
            this.decBtn.HighEmphasis = true;
            this.decBtn.Icon = null;
            this.decBtn.Location = new System.Drawing.Point(1134, 92);
            this.decBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.decBtn.Name = "decBtn";
            this.decBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.decBtn.Size = new System.Drawing.Size(123, 36);
            this.decBtn.TabIndex = 12;
            this.decBtn.Text = "Déconnexion";
            this.decBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.decBtn.UseAccentColor = true;
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.adminHistorique1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 230);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1429, 805);
            this.panel3.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(-4, 0);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1429, 804);
            this.adminDashboard1.TabIndex = 4;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(-3, 0);
            this.adminAddUsers1.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1429, 804);
            this.adminAddUsers1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1428, 804);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 1);
            this.adminAddCategories1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1429, 804);
            this.adminAddCategories1.TabIndex = 1;
            // 
            // adminHistorique1
            // 
            this.adminHistorique1.Location = new System.Drawing.Point(-3, 1);
            this.adminHistorique1.Name = "adminHistorique1";
            this.adminHistorique1.Size = new System.Drawing.Size(1429, 804);
            this.adminHistorique1.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 1038);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton dashboard_btn;
        private MaterialSkin.Controls.MaterialButton usersBtn;
        private MaterialSkin.Controls.MaterialButton productBtn;
        private MaterialSkin.Controls.MaterialButton catBtn;
        private MaterialSkin.Controls.MaterialButton histBtn;
        private MaterialSkin.Controls.MaterialButton decBtn;
        private adminHistorique adminHistorique1;
        private adminDashboard adminDashboard1;
        private adminAddUsers adminAddUsers1;
        private adminAddProducts adminAddProducts1;
        private adminAddCategories adminAddCategories1;
    }
}