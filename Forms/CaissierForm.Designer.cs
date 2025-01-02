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
            this.orders_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.orders_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.customers_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 180);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // orders_btn
            // 
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.ForeColor = System.Drawing.Color.Black;
            this.orders_btn.Location = new System.Drawing.Point(507, 86);
            this.orders_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(255, 39);
            this.orders_btn.TabIndex = 6;
            this.orders_btn.Text = "Commandes";
            this.orders_btn.UseVisualStyleBackColor = true;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 636);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Red;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(1135, 11);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(164, 41);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Déconnexion";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.Black;
            this.customers_btn.Location = new System.Drawing.Point(884, 86);
            this.customers_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(360, 39);
            this.customers_btn.TabIndex = 4;
            this.customers_btn.Text = "Historique des commandes";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.dashboard_btn.Location = new System.Drawing.Point(216, 86);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(171, 39);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(560, 15);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(110, 25);
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1324, 908);
            this.panel3.TabIndex = 3;
            // 
            // caissierDashboard1
            // 
            this.caissierDashboard1.Location = new System.Drawing.Point(0, 181);
            this.caissierDashboard1.Name = "caissierDashboard1";
            this.caissierDashboard1.Size = new System.Drawing.Size(1324, 729);
            this.caissierDashboard1.TabIndex = 2;
            // 
            // caissierCommandes1
            // 
            this.caissierCommandes1.Location = new System.Drawing.Point(0, 178);
            this.caissierCommandes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caissierCommandes1.Name = "caissierCommandes1";
            this.caissierCommandes1.Size = new System.Drawing.Size(1339, 735);
            this.caissierCommandes1.TabIndex = 1;
            // 
            // customerHistoriqueCommande1
            // 
            this.customerHistoriqueCommande1.Location = new System.Drawing.Point(0, 179);
            this.customerHistoriqueCommande1.Name = "customerHistoriqueCommande1";
            this.customerHistoriqueCommande1.Size = new System.Drawing.Size(1324, 729);
            this.customerHistoriqueCommande1.TabIndex = 0;
            // 
            // CaissierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 908);
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
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panel3;
        private caissierDashboard caissierDashboard1;
        private CaissierCommandes caissierCommandes1;
        private customerHistoriqueCommande customerHistoriqueCommande1;
    }
}