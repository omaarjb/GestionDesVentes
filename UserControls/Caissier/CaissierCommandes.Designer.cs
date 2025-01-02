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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaissierCommandes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.delOrdBtn = new MaterialSkin.Controls.MaterialButton();
            this.ordReceipBtn = new MaterialSkin.Controls.MaterialButton();
            this.ordPayBtn = new MaterialSkin.Controls.MaterialButton();
            this.orders_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.orders_totalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders_prodId = new MaterialSkin.Controls.MaterialComboBox();
            this.orders_category = new MaterialSkin.Controls.MaterialComboBox();
            this.clearOrdBtn = new MaterialSkin.Controls.MaterialButton();
            this.addOrdBtn = new MaterialSkin.Controls.MaterialButton();
            this.orders_quantity = new System.Windows.Forms.NumericUpDown();
            this.orders_price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.orders_prodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.orders_montant = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.panel1.Controls.Add(this.delOrdBtn);
            this.panel1.Controls.Add(this.ordReceipBtn);
            this.panel1.Controls.Add(this.ordPayBtn);
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
            this.panel1.Size = new System.Drawing.Size(697, 773);
            this.panel1.TabIndex = 0;
            // 
            // delOrdBtn
            // 
            this.delOrdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delOrdBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delOrdBtn.Depth = 0;
            this.delOrdBtn.HighEmphasis = true;
            this.delOrdBtn.Icon = null;
            this.delOrdBtn.Location = new System.Drawing.Point(455, 645);
            this.delOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delOrdBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delOrdBtn.Name = "delOrdBtn";
            this.delOrdBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delOrdBtn.Size = new System.Drawing.Size(79, 36);
            this.delOrdBtn.TabIndex = 27;
            this.delOrdBtn.Text = "retirer";
            this.delOrdBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delOrdBtn.UseAccentColor = true;
            this.delOrdBtn.UseVisualStyleBackColor = true;
            this.delOrdBtn.Click += new System.EventHandler(this.delOrdBtn_Click);
            // 
            // ordReceipBtn
            // 
            this.ordReceipBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordReceipBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ordReceipBtn.Depth = 0;
            this.ordReceipBtn.HighEmphasis = true;
            this.ordReceipBtn.Icon = null;
            this.ordReceipBtn.Location = new System.Drawing.Point(287, 645);
            this.ordReceipBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ordReceipBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ordReceipBtn.Name = "ordReceipBtn";
            this.ordReceipBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ordReceipBtn.Size = new System.Drawing.Size(64, 36);
            this.ordReceipBtn.TabIndex = 26;
            this.ordReceipBtn.Text = "recu";
            this.ordReceipBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ordReceipBtn.UseAccentColor = false;
            this.ordReceipBtn.UseVisualStyleBackColor = true;
            this.ordReceipBtn.Click += new System.EventHandler(this.ordReceipBtn_Click);
            // 
            // ordPayBtn
            // 
            this.ordPayBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordPayBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ordPayBtn.Depth = 0;
            this.ordPayBtn.HighEmphasis = true;
            this.ordPayBtn.Icon = null;
            this.ordPayBtn.Location = new System.Drawing.Point(107, 645);
            this.ordPayBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ordPayBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ordPayBtn.Name = "ordPayBtn";
            this.ordPayBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ordPayBtn.Size = new System.Drawing.Size(67, 36);
            this.ordPayBtn.TabIndex = 25;
            this.ordPayBtn.Text = "payer";
            this.ordPayBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ordPayBtn.UseAccentColor = false;
            this.ordPayBtn.UseVisualStyleBackColor = true;
            this.ordPayBtn.Click += new System.EventHandler(this.ordPayBtn_Click);
            // 
            // orders_change
            // 
            this.orders_change.AutoSize = true;
            this.orders_change.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.orders_change.Location = new System.Drawing.Point(201, 577);
            this.orders_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_change.Name = "orders_change";
            this.orders_change.Size = new System.Drawing.Size(44, 22);
            this.orders_change.TabIndex = 12;
            this.orders_change.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(117, 577);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 22);
            this.label14.TabIndex = 11;
            this.label14.Text = "Reste";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(90, 508);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Montant";
            // 
            // orders_totalPrice
            // 
            this.orders_totalPrice.AutoSize = true;
            this.orders_totalPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.orders_totalPrice.Location = new System.Drawing.Point(201, 449);
            this.orders_totalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_totalPrice.Name = "orders_totalPrice";
            this.orders_totalPrice.Size = new System.Drawing.Size(44, 22);
            this.orders_totalPrice.TabIndex = 8;
            this.orders_totalPrice.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(117, 449);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
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
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Les commandes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 366);
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
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Produits disponibles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.orders_prodId);
            this.panel2.Controls.Add(this.orders_category);
            this.panel2.Controls.Add(this.clearOrdBtn);
            this.panel2.Controls.Add(this.addOrdBtn);
            this.panel2.Controls.Add(this.orders_quantity);
            this.panel2.Controls.Add(this.orders_price);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.orders_prodName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(732, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 379);
            this.panel2.TabIndex = 1;
            // 
            // orders_prodId
            // 
            this.orders_prodId.AutoResize = false;
            this.orders_prodId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orders_prodId.Depth = 0;
            this.orders_prodId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.orders_prodId.DropDownHeight = 174;
            this.orders_prodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orders_prodId.DropDownWidth = 121;
            this.orders_prodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orders_prodId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orders_prodId.FormattingEnabled = true;
            this.orders_prodId.IntegralHeight = false;
            this.orders_prodId.ItemHeight = 43;
            this.orders_prodId.Location = new System.Drawing.Point(331, 59);
            this.orders_prodId.MaxDropDownItems = 4;
            this.orders_prodId.MouseState = MaterialSkin.MouseState.OUT;
            this.orders_prodId.Name = "orders_prodId";
            this.orders_prodId.Size = new System.Drawing.Size(277, 49);
            this.orders_prodId.StartIndex = 0;
            this.orders_prodId.TabIndex = 31;
            this.orders_prodId.SelectedIndexChanged += new System.EventHandler(this.orders_prodId_SelectedIndexChanged);
            // 
            // orders_category
            // 
            this.orders_category.AutoResize = false;
            this.orders_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orders_category.Depth = 0;
            this.orders_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.orders_category.DropDownHeight = 174;
            this.orders_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orders_category.DropDownWidth = 121;
            this.orders_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orders_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orders_category.FormattingEnabled = true;
            this.orders_category.IntegralHeight = false;
            this.orders_category.ItemHeight = 43;
            this.orders_category.Location = new System.Drawing.Point(27, 59);
            this.orders_category.MaxDropDownItems = 4;
            this.orders_category.MouseState = MaterialSkin.MouseState.OUT;
            this.orders_category.Name = "orders_category";
            this.orders_category.Size = new System.Drawing.Size(278, 49);
            this.orders_category.StartIndex = 0;
            this.orders_category.TabIndex = 30;
            this.orders_category.SelectedIndexChanged += new System.EventHandler(this.orders_category_SelectedIndexChanged);
            // 
            // clearOrdBtn
            // 
            this.clearOrdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearOrdBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearOrdBtn.Depth = 0;
            this.clearOrdBtn.HighEmphasis = true;
            this.clearOrdBtn.Icon = null;
            this.clearOrdBtn.Location = new System.Drawing.Point(390, 325);
            this.clearOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearOrdBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearOrdBtn.Name = "clearOrdBtn";
            this.clearOrdBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearOrdBtn.Size = new System.Drawing.Size(83, 36);
            this.clearOrdBtn.TabIndex = 28;
            this.clearOrdBtn.Text = "effacer";
            this.clearOrdBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearOrdBtn.UseAccentColor = true;
            this.clearOrdBtn.UseVisualStyleBackColor = true;
            this.clearOrdBtn.Click += new System.EventHandler(this.clearOrdBtn_Click);
            // 
            // addOrdBtn
            // 
            this.addOrdBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addOrdBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addOrdBtn.Depth = 0;
            this.addOrdBtn.HighEmphasis = true;
            this.addOrdBtn.Icon = null;
            this.addOrdBtn.Location = new System.Drawing.Point(220, 325);
            this.addOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addOrdBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addOrdBtn.Name = "addOrdBtn";
            this.addOrdBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addOrdBtn.Size = new System.Drawing.Size(85, 36);
            this.addOrdBtn.TabIndex = 27;
            this.addOrdBtn.Text = "ajouter";
            this.addOrdBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addOrdBtn.UseAccentColor = false;
            this.addOrdBtn.UseVisualStyleBackColor = true;
            this.addOrdBtn.Click += new System.EventHandler(this.addOrdBtn_Click);
            // 
            // orders_quantity
            // 
            this.orders_quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.orders_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_quantity.Location = new System.Drawing.Point(31, 180);
            this.orders_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orders_quantity.Name = "orders_quantity";
            this.orders_quantity.Size = new System.Drawing.Size(259, 27);
            this.orders_quantity.TabIndex = 24;
            // 
            // orders_price
            // 
            this.orders_price.AutoSize = true;
            this.orders_price.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.orders_price.Location = new System.Drawing.Point(216, 267);
            this.orders_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_price.Name = "orders_price";
            this.orders_price.Size = new System.Drawing.Size(30, 22);
            this.orders_price.TabIndex = 19;
            this.orders_price.Text = ".....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(104, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prix";
            // 
            // orders_prodName
            // 
            this.orders_prodName.AutoSize = true;
            this.orders_prodName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.orders_prodName.Location = new System.Drawing.Point(216, 233);
            this.orders_prodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orders_prodName.Name = "orders_prodName";
            this.orders_prodName.Size = new System.Drawing.Size(30, 22);
            this.orders_prodName.TabIndex = 17;
            this.orders_prodName.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nom du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(327, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Catégorie";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(732, 404);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 381);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(20, 57);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(636, 306);
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
            // orders_montant
            // 
            this.orders_montant.AnimateReadOnly = false;
            this.orders_montant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orders_montant.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.orders_montant.Depth = 0;
            this.orders_montant.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.orders_montant.HideSelection = true;
            this.orders_montant.LeadingIcon = null;
            this.orders_montant.Location = new System.Drawing.Point(205, 498);
            this.orders_montant.MaxLength = 32767;
            this.orders_montant.MouseState = MaterialSkin.MouseState.OUT;
            this.orders_montant.Name = "orders_montant";
            this.orders_montant.PasswordChar = '\0';
            this.orders_montant.PrefixSuffixText = null;
            this.orders_montant.ReadOnly = false;
            this.orders_montant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orders_montant.SelectedText = "";
            this.orders_montant.SelectionLength = 0;
            this.orders_montant.SelectionStart = 0;
            this.orders_montant.ShortcutsEnabled = true;
            this.orders_montant.Size = new System.Drawing.Size(224, 48);
            this.orders_montant.TabIndex = 28;
            this.orders_montant.TabStop = false;
            this.orders_montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orders_montant.TrailingIcon = null;
            this.orders_montant.UseSystemPasswordChar = false;
            this.orders_montant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orders_montant_KeyDown_2);
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
            this.Size = new System.Drawing.Size(1429, 804);
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
       
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orders_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label orders_prodName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label orders_totalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label orders_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown orders_quantity;
       
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
       
        
        
        private MaterialSkin.Controls.MaterialButton addOrdBtn;
        private MaterialSkin.Controls.MaterialButton clearOrdBtn;
        private MaterialSkin.Controls.MaterialButton ordPayBtn;
        private MaterialSkin.Controls.MaterialButton ordReceipBtn;
        private MaterialSkin.Controls.MaterialButton delOrdBtn;
       
        private MaterialSkin.Controls.MaterialComboBox orders_category;
        private MaterialSkin.Controls.MaterialComboBox orders_prodId;
        private MaterialSkin.Controls.MaterialTextBox2 orders_montant;
    }
}
