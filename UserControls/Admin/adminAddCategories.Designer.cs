namespace GestionDeVente
{
    partial class adminAddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearCatBtn = new MaterialSkin.Controls.MaterialButton();
            this.delCatBtn = new MaterialSkin.Controls.MaterialButton();
            this.ubdCatBtn = new MaterialSkin.Controls.MaterialButton();
            this.addCatBtn = new MaterialSkin.Controls.MaterialButton();
            this.addCategories_status = new MaterialSkin.Controls.MaterialComboBox();
            this.addCategories_category = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 665);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Les catégories";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(60, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Statut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catégorie";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(576, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 740);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.clearCatBtn);
            this.panel1.Controls.Add(this.delCatBtn);
            this.panel1.Controls.Add(this.ubdCatBtn);
            this.panel1.Controls.Add(this.addCatBtn);
            this.panel1.Controls.Add(this.addCategories_status);
            this.panel1.Controls.Add(this.addCategories_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 740);
            this.panel1.TabIndex = 2;
            // 
            // clearCatBtn
            // 
            this.clearCatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearCatBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearCatBtn.Depth = 0;
            this.clearCatBtn.HighEmphasis = true;
            this.clearCatBtn.Icon = null;
            this.clearCatBtn.Location = new System.Drawing.Point(265, 569);
            this.clearCatBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearCatBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearCatBtn.Name = "clearCatBtn";
            this.clearCatBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearCatBtn.Size = new System.Drawing.Size(83, 36);
            this.clearCatBtn.TabIndex = 17;
            this.clearCatBtn.Text = "Effacer";
            this.clearCatBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearCatBtn.UseAccentColor = false;
            this.clearCatBtn.UseVisualStyleBackColor = true;
            this.clearCatBtn.Click += new System.EventHandler(this.clearCatBtn_Click);
            // 
            // delCatBtn
            // 
            this.delCatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delCatBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delCatBtn.Depth = 0;
            this.delCatBtn.HighEmphasis = true;
            this.delCatBtn.Icon = null;
            this.delCatBtn.Location = new System.Drawing.Point(91, 569);
            this.delCatBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delCatBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delCatBtn.Name = "delCatBtn";
            this.delCatBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delCatBtn.Size = new System.Drawing.Size(102, 36);
            this.delCatBtn.TabIndex = 16;
            this.delCatBtn.Text = "Supprimer";
            this.delCatBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delCatBtn.UseAccentColor = true;
            this.delCatBtn.UseVisualStyleBackColor = true;
            this.delCatBtn.Click += new System.EventHandler(this.delCatBtn_Click);
            // 
            // ubdCatBtn
            // 
            this.ubdCatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ubdCatBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ubdCatBtn.Depth = 0;
            this.ubdCatBtn.HighEmphasis = true;
            this.ubdCatBtn.Icon = null;
            this.ubdCatBtn.Location = new System.Drawing.Point(264, 464);
            this.ubdCatBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ubdCatBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ubdCatBtn.Name = "ubdCatBtn";
            this.ubdCatBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ubdCatBtn.Size = new System.Drawing.Size(84, 36);
            this.ubdCatBtn.TabIndex = 15;
            this.ubdCatBtn.Text = "Modifer";
            this.ubdCatBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ubdCatBtn.UseAccentColor = true;
            this.ubdCatBtn.UseVisualStyleBackColor = true;
            this.ubdCatBtn.Click += new System.EventHandler(this.ubdCatBtn_Click);
            // 
            // addCatBtn
            // 
            this.addCatBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCatBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addCatBtn.Depth = 0;
            this.addCatBtn.HighEmphasis = true;
            this.addCatBtn.Icon = null;
            this.addCatBtn.Location = new System.Drawing.Point(91, 464);
            this.addCatBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCatBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addCatBtn.Size = new System.Drawing.Size(85, 36);
            this.addCatBtn.TabIndex = 14;
            this.addCatBtn.Text = "Ajouter";
            this.addCatBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addCatBtn.UseAccentColor = false;
            this.addCatBtn.UseVisualStyleBackColor = true;
            this.addCatBtn.Click += new System.EventHandler(this.addCatBtn_Click);
            // 
            // addCategories_status
            // 
            this.addCategories_status.AutoResize = false;
            this.addCategories_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCategories_status.Depth = 0;
            this.addCategories_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.addCategories_status.DropDownHeight = 174;
            this.addCategories_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategories_status.DropDownWidth = 121;
            this.addCategories_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addCategories_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addCategories_status.FormattingEnabled = true;
            this.addCategories_status.IntegralHeight = false;
            this.addCategories_status.ItemHeight = 43;
            this.addCategories_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addCategories_status.Location = new System.Drawing.Point(64, 307);
            this.addCategories_status.MaxDropDownItems = 4;
            this.addCategories_status.MouseState = MaterialSkin.MouseState.OUT;
            this.addCategories_status.Name = "addCategories_status";
            this.addCategories_status.Size = new System.Drawing.Size(336, 49);
            this.addCategories_status.StartIndex = 0;
            this.addCategories_status.TabIndex = 13;
            // 
            // addCategories_category
            // 
            this.addCategories_category.AnimateReadOnly = false;
            this.addCategories_category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCategories_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addCategories_category.Depth = 0;
            this.addCategories_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addCategories_category.HideSelection = true;
            this.addCategories_category.LeadingIcon = null;
            this.addCategories_category.Location = new System.Drawing.Point(64, 147);
            this.addCategories_category.MaxLength = 32767;
            this.addCategories_category.MouseState = MaterialSkin.MouseState.OUT;
            this.addCategories_category.Name = "addCategories_category";
            this.addCategories_category.PasswordChar = '\0';
            this.addCategories_category.PrefixSuffixText = null;
            this.addCategories_category.ReadOnly = false;
            this.addCategories_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCategories_category.SelectedText = "";
            this.addCategories_category.SelectionLength = 0;
            this.addCategories_category.SelectionStart = 0;
            this.addCategories_category.ShortcutsEnabled = true;
            this.addCategories_category.Size = new System.Drawing.Size(336, 48);
            this.addCategories_category.TabIndex = 12;
            this.addCategories_category.TabStop = false;
            this.addCategories_category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addCategories_category.TrailingIcon = null;
            this.addCategories_category.UseSystemPasswordChar = false;
            // 
            // adminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminAddCategories";
            this.Size = new System.Drawing.Size(1429, 804);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 addCategories_category;
        private MaterialSkin.Controls.MaterialComboBox addCategories_status;
        private MaterialSkin.Controls.MaterialButton addCatBtn;
        private MaterialSkin.Controls.MaterialButton ubdCatBtn;
        private MaterialSkin.Controls.MaterialButton delCatBtn;
        private MaterialSkin.Controls.MaterialButton clearCatBtn;
    }
}
