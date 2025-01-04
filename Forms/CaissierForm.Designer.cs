namespace GestionDeVente
{
    partial class CaissierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaissierForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.decBtn = new MaterialSkin.Controls.MaterialButton();
            this.histBtn = new MaterialSkin.Controls.MaterialButton();
            this.ordBtn = new MaterialSkin.Controls.MaterialButton();
            this.dashBtn = new MaterialSkin.Controls.MaterialButton();
            this.welcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.caissierDashboard1 = new GestionDeVente.caissierDashboard();
            this.caissierCommandes1 = new GestionDeVente.CaissierCommandes();
            this.customerHistoriqueCommande1 = new GestionDeVente.customerHistoriqueCommande();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.decBtn);
            this.panel1.Controls.Add(this.histBtn);
            this.panel1.Controls.Add(this.ordBtn);
            this.panel1.Controls.Add(this.dashBtn);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 127);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // decBtn
            // 
            this.decBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.decBtn.Depth = 0;
            this.decBtn.HighEmphasis = true;
            this.decBtn.Icon = null;
            this.decBtn.Location = new System.Drawing.Point(1186, 15);
            this.decBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.decBtn.Name = "decBtn";
            this.decBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.decBtn.Size = new System.Drawing.Size(123, 36);
            this.decBtn.TabIndex = 10;
            this.decBtn.Text = "Déconnexion";
            this.decBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.decBtn.UseAccentColor = true;
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // histBtn
            // 
            this.histBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.histBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.histBtn.Depth = 0;
            this.histBtn.HighEmphasis = true;
            this.histBtn.Icon = null;
            this.histBtn.Location = new System.Drawing.Point(896, 69);
            this.histBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.histBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.histBtn.Name = "histBtn";
            this.histBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.histBtn.Size = new System.Drawing.Size(233, 36);
            this.histBtn.TabIndex = 9;
            this.histBtn.Text = "Historique des commandes";
            this.histBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.histBtn.UseAccentColor = false;
            this.histBtn.UseVisualStyleBackColor = true;
            this.histBtn.Click += new System.EventHandler(this.histBtn_Click);
            // 
            // ordBtn
            // 
            this.ordBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ordBtn.Depth = 0;
            this.ordBtn.HighEmphasis = true;
            this.ordBtn.Icon = null;
            this.ordBtn.Location = new System.Drawing.Point(565, 69);
            this.ordBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ordBtn.Name = "ordBtn";
            this.ordBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ordBtn.Size = new System.Drawing.Size(143, 36);
            this.ordBtn.TabIndex = 8;
            this.ordBtn.Text = "Les Commandes";
            this.ordBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ordBtn.UseAccentColor = false;
            this.ordBtn.UseVisualStyleBackColor = true;
            this.ordBtn.Click += new System.EventHandler(this.ordBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dashBtn.Depth = 0;
            this.dashBtn.HighEmphasis = true;
            this.dashBtn.Icon = null;
            this.dashBtn.Location = new System.Drawing.Point(239, 69);
            this.dashBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dashBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dashBtn.Size = new System.Drawing.Size(108, 36);
            this.dashBtn.TabIndex = 7;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dashBtn.UseAccentColor = false;
            this.dashBtn.UseVisualStyleBackColor = true;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.welcome.Location = new System.Drawing.Point(560, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(114, 29);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Bienvenue ";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.caissierDashboard1);
            this.panel3.Controls.Add(this.caissierCommandes1);
            this.panel3.Controls.Add(this.customerHistoriqueCommande1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1430, 971);
            this.panel3.TabIndex = 3;
            // 
            // caissierDashboard1
            // 
            this.caissierDashboard1.Location = new System.Drawing.Point(1, 131);
            this.caissierDashboard1.Name = "caissierDashboard1";
            this.caissierDashboard1.Size = new System.Drawing.Size(1429, 710);
            this.caissierDashboard1.TabIndex = 2;
            // 
            // caissierCommandes1
            // 
            this.caissierCommandes1.Location = new System.Drawing.Point(-2, 131);
            this.caissierCommandes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caissierCommandes1.Name = "caissierCommandes1";
            this.caissierCommandes1.Size = new System.Drawing.Size(1429, 710);
            this.caissierCommandes1.TabIndex = 1;
            // 
            // customerHistoriqueCommande1
            // 
            this.customerHistoriqueCommande1.Location = new System.Drawing.Point(-2, 132);
            this.customerHistoriqueCommande1.Name = "customerHistoriqueCommande1";
            this.customerHistoriqueCommande1.Size = new System.Drawing.Size(1429, 710);
            this.customerHistoriqueCommande1.TabIndex = 0;
            // 
            // CaissierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1038);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CaissierForm";
            this.Text = "Caissier - Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton dashBtn;
        private MaterialSkin.Controls.MaterialButton ordBtn;
        private MaterialSkin.Controls.MaterialButton histBtn;
        private MaterialSkin.Controls.MaterialButton decBtn;
        private caissierDashboard caissierDashboard1;
        private CaissierCommandes caissierCommandes1;
        private customerHistoriqueCommande customerHistoriqueCommande1;
    }
}