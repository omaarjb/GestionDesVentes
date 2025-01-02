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
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.clients_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.welcomeAdmin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new GestionDeVente.adminDashboard();
            this.adminAddUsers1 = new GestionDeVente.adminAddUsers();
            this.adminAddProducts1 = new GestionDeVente.adminAddProducts();
            this.adminAddCategories1 = new GestionDeVente.adminAddCategories();
            this.adminCustomers1 = new GestionDeVente.adminHistorique();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.addCategories_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.clients_btn);
            this.panel1.Controls.Add(this.addProducts_btn);
            this.panel1.Controls.Add(this.addUsers_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.welcomeAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.ForeColor = System.Drawing.Color.Black;
            this.addCategories_btn.Location = new System.Drawing.Point(736, 86);
            this.addCategories_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(255, 39);
            this.addCategories_btn.TabIndex = 6;
            this.addCategories_btn.Text = "Ajouter catégories";
            this.addCategories_btn.UseVisualStyleBackColor = true;
            this.addCategories_btn.Click += new System.EventHandler(this.button5_Click_1);
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
            this.logout_btn.Location = new System.Drawing.Point(1123, 11);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(176, 44);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Déconnexion";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // clients_btn
            // 
            this.clients_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_btn.ForeColor = System.Drawing.Color.Black;
            this.clients_btn.Location = new System.Drawing.Point(1015, 86);
            this.clients_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clients_btn.Name = "clients_btn";
            this.clients_btn.Size = new System.Drawing.Size(171, 39);
            this.clients_btn.TabIndex = 4;
            this.clients_btn.Text = "Historique";
            this.clients_btn.UseVisualStyleBackColor = true;
            this.clients_btn.Click += new System.EventHandler(this.clients_btn_Click_1);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.Color.Black;
            this.addProducts_btn.Location = new System.Drawing.Point(456, 86);
            this.addProducts_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(255, 39);
            this.addProducts_btn.TabIndex = 3;
            this.addProducts_btn.Text = "Ajouter des produits";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.Color.Black;
            this.addUsers_btn.Location = new System.Drawing.Point(211, 86);
            this.addUsers_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(221, 39);
            this.addUsers_btn.TabIndex = 2;
            this.addUsers_btn.Text = "Ajouter utlisateur";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 86);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(171, 39);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddUsers1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.adminCustomers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1324, 728);
            this.panel3.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, -2);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1324, 729);
            this.adminDashboard1.TabIndex = 4;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUsers1.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1324, 728);
            this.adminAddUsers1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 1);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(4);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1324, 729);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, -3);
            this.adminAddCategories1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1324, 729);
            this.adminAddCategories1.TabIndex = 1;
            // 
            // adminCustomers1
            // 
            this.adminCustomers1.Location = new System.Drawing.Point(0, 1);
            this.adminCustomers1.Name = "adminCustomers1";
            this.adminCustomers1.Size = new System.Drawing.Size(1324, 729);
            this.adminCustomers1.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 908);
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

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeAdmin;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button clients_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addCategories_btn;
        private adminDashboard adminDashboard1;
        private adminAddUsers adminAddUsers1;
        private adminAddProducts adminAddProducts1;
        private adminAddCategories adminAddCategories1;
        private adminHistorique adminCustomers1;
    }
}