namespace GestionDeVente
{
    partial class CaissierCommandes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaissierCommandes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orders_montant = new System.Windows.Forms.TextBox();
            this.orders_removeBtn = new System.Windows.Forms.Button();
            this.orders_recieptBtn = new System.Windows.Forms.Button();
            this.orders_payBtn = new System.Windows.Forms.Button();
            this.orders_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.orders_totalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders_quantity = new System.Windows.Forms.NumericUpDown();
            this.orders_clearBtn = new System.Windows.Forms.Button();
            this.orders_addBtn = new System.Windows.Forms.Button();
            this.orders_price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.orders_prodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orders_prodId = new System.Windows.Forms.ComboBox();
            this.orders_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.orders_montant);
            this.panel1.Controls.Add(this.orders_removeBtn);
            this.panel1.Controls.Add(this.orders_recieptBtn);
            this.panel1.Controls.Add(this.orders_payBtn);
            this.panel1.Controls.Add(this.orders_change);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.orders_totalPrice);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 702);
            this.panel1.TabIndex = 0;
            // 
            // orders_montant
            // 
            this.orders_montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_montant.Location = new System.Drawing.Point(195, 464);
            this.orders_montant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_montant.Name = "orders_montant";
            this.orders_montant.Size = new System.Drawing.Size(181, 27);
            this.orders_montant.TabIndex = 24;
            this.orders_montant.TextChanged += new System.EventHandler(this.orders_montant_TextChanged);
            this.orders_montant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orders_montant_KeyDown);
            // 
            // orders_removeBtn
            // 
            this.orders_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orders_removeBtn.FlatAppearance.BorderSize = 0;
            this.orders_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_removeBtn.ForeColor = System.Drawing.Color.White;
            this.orders_removeBtn.Location = new System.Drawing.Point(433, 623);
            this.orders_removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_removeBtn.Name = "orders_removeBtn";
            this.orders_removeBtn.Size = new System.Drawing.Size(168, 37);
            this.orders_removeBtn.TabIndex = 23;
            this.orders_removeBtn.Text = "RETIRER";
            this.orders_removeBtn.UseVisualStyleBackColor = false;
            this.orders_removeBtn.Click += new System.EventHandler(this.orders_removeBtn_Click);
            // 
            // orders_recieptBtn
            // 
            this.orders_recieptBtn.BackColor = System.Drawing.Color.Orange;
            this.orders_recieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_recieptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_recieptBtn.Location = new System.Drawing.Point(227, 623);
            this.orders_recieptBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_recieptBtn.Name = "orders_recieptBtn";
            this.orders_recieptBtn.Size = new System.Drawing.Size(163, 34);
            this.orders_recieptBtn.TabIndex = 22;
            this.orders_recieptBtn.Text = "RECU";
            this.orders_recieptBtn.UseVisualStyleBackColor = false;
            this.orders_recieptBtn.Click += new System.EventHandler(this.orders_recieptBtn_Click);
            // 
            // orders_payBtn
            // 
            this.orders_payBtn.BackColor = System.Drawing.Color.Lime;
            this.orders_payBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orders_payBtn.FlatAppearance.BorderSize = 0;
            this.orders_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_payBtn.Location = new System.Drawing.Point(17, 622);
            this.orders_payBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_payBtn.Name = "orders_payBtn";
            this.orders_payBtn.Size = new System.Drawing.Size(160, 36);
            this.orders_payBtn.TabIndex = 21;
            this.orders_payBtn.Text = "PAYER";
            this.orders_payBtn.UseVisualStyleBackColor = false;
            this.orders_payBtn.Click += new System.EventHandler(this.orders_payBtn_Click);
            // 
            // orders_change
            // 
            this.orders_change.AutoSize = true;
            this.orders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_change.Location = new System.Drawing.Point(191, 514);
            this.orders_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_change.Name = "orders_change";
            this.orders_change.Size = new System.Drawing.Size(40, 20);
            this.orders_change.TabIndex = 12;
            this.orders_change.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(107, 514);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Reste";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 464);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Montant";
            // 
            // orders_totalPrice
            // 
            this.orders_totalPrice.AutoSize = true;
            this.orders_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_totalPrice.Location = new System.Drawing.Point(191, 420);
            this.orders_totalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_totalPrice.Name = "orders_totalPrice";
            this.orders_totalPrice.Size = new System.Drawing.Size(40, 20);
            this.orders_totalPrice.TabIndex = 8;
            this.orders_totalPrice.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Les commandes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 331);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Produits disponibles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.orders_quantity);
            this.panel2.Controls.Add(this.orders_clearBtn);
            this.panel2.Controls.Add(this.orders_addBtn);
            this.panel2.Controls.Add(this.orders_price);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.orders_prodName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.orders_prodId);
            this.panel2.Controls.Add(this.orders_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(675, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 327);
            this.panel2.TabIndex = 1;
            // 
            // orders_quantity
            // 
            this.orders_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_quantity.Location = new System.Drawing.Point(28, 135);
            this.orders_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_quantity.Name = "orders_quantity";
            this.orders_quantity.Size = new System.Drawing.Size(259, 27);
            this.orders_quantity.TabIndex = 24;
            // 
            // orders_clearBtn
            // 
            this.orders_clearBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.orders_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_clearBtn.Location = new System.Drawing.Point(335, 272);
            this.orders_clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_clearBtn.Name = "orders_clearBtn";
            this.orders_clearBtn.Size = new System.Drawing.Size(221, 36);
            this.orders_clearBtn.TabIndex = 21;
            this.orders_clearBtn.Text = "EFFACER";
            this.orders_clearBtn.UseVisualStyleBackColor = false;
            this.orders_clearBtn.Click += new System.EventHandler(this.orders_clearBtn_Click);
            // 
            // orders_addBtn
            // 
            this.orders_addBtn.BackColor = System.Drawing.Color.Lime;
            this.orders_addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orders_addBtn.FlatAppearance.BorderSize = 0;
            this.orders_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_addBtn.Location = new System.Drawing.Point(83, 272);
            this.orders_addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_addBtn.Name = "orders_addBtn";
            this.orders_addBtn.Size = new System.Drawing.Size(205, 36);
            this.orders_addBtn.TabIndex = 20;
            this.orders_addBtn.Text = "AJOUTER";
            this.orders_addBtn.UseVisualStyleBackColor = false;
            this.orders_addBtn.Click += new System.EventHandler(this.orders_addBtn_Click);
            // 
            // orders_price
            // 
            this.orders_price.AutoSize = true;
            this.orders_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_price.Location = new System.Drawing.Point(176, 222);
            this.orders_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_price.Name = "orders_price";
            this.orders_price.Size = new System.Drawing.Size(29, 20);
            this.orders_price.TabIndex = 19;
            this.orders_price.Text = ".....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prix";
            // 
            // orders_prodName
            // 
            this.orders_prodName.AutoSize = true;
            this.orders_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodName.Location = new System.Drawing.Point(176, 188);
            this.orders_prodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_prodName.Name = "orders_prodName";
            this.orders_prodName.Size = new System.Drawing.Size(29, 20);
            this.orders_prodName.TabIndex = 17;
            this.orders_prodName.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nom du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantité";
            // 
            // orders_prodId
            // 
            this.orders_prodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodId.FormattingEnabled = true;
            this.orders_prodId.Location = new System.Drawing.Point(323, 48);
            this.orders_prodId.Margin = new System.Windows.Forms.Padding(4);
            this.orders_prodId.Name = "orders_prodId";
            this.orders_prodId.Size = new System.Drawing.Size(257, 28);
            this.orders_prodId.TabIndex = 13;
            this.orders_prodId.SelectedIndexChanged += new System.EventHandler(this.orders_prodId_SelectedIndexChanged);
            // 
            // orders_category
            // 
            this.orders_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_category.FormattingEnabled = true;
            this.orders_category.Location = new System.Drawing.Point(28, 48);
            this.orders_category.Margin = new System.Windows.Forms.Padding(4);
            this.orders_category.Name = "orders_category";
            this.orders_category.Size = new System.Drawing.Size(257, 28);
            this.orders_category.TabIndex = 12;
            this.orders_category.SelectedIndexChanged += new System.EventHandler(this.orders_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Catégorie";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(675, 357);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 357);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(20, 57);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(585, 283);
            this.dataGridView3.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CaissierCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CaissierCommandes";
            this.Size = new System.Drawing.Size(1339, 735);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orders_prodId;
        private System.Windows.Forms.ComboBox orders_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orders_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label orders_prodName;
        private System.Windows.Forms.Button orders_addBtn;
        private System.Windows.Forms.Button orders_clearBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label orders_totalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button orders_payBtn;
        private System.Windows.Forms.Label orders_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button orders_recieptBtn;
        private System.Windows.Forms.Button orders_removeBtn;
        private System.Windows.Forms.NumericUpDown orders_quantity;
        private System.Windows.Forms.TextBox orders_montant;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
