namespace ProNatur_BioMarkt
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(81, 30);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(150, 13);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            this.textBoxProductBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductBrand.ForeColor = System.Drawing.Color.White;
            this.textBoxProductBrand.Location = new System.Drawing.Point(81, 59);
            this.textBoxProductBrand.Name = "textBoxProductBrand";
            this.textBoxProductBrand.Size = new System.Drawing.Size(150, 13);
            this.textBoxProductBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxProductPrice.Location = new System.Drawing.Point(81, 120);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(100, 13);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Früchte",
            "Getränke"});
            this.comboBoxProductCategory.Location = new System.Drawing.Point(81, 88);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(125, 21);
            this.comboBoxProductCategory.TabIndex = 8;
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.ForeColor = System.Drawing.Color.White;
            this.btnProductSave.Location = new System.Drawing.Point(81, 139);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Hinzufügen";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSaveAndUpdate_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductClear.ForeColor = System.Drawing.Color.White;
            this.btnProductClear.Location = new System.Drawing.Point(162, 139);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(95, 23);
            this.btnProductClear.TabIndex = 11;
            this.btnProductClear.Text = "Felder Leeren";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(263, 139);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 12;
            this.btnProductDelete.Text = "Löschen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowUserToAddRows = false;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(12, 187);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            this.productsDGV.RowHeadersVisible = false;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(775, 262);
            this.productsDGV.TabIndex = 13;
            this.productsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellClick);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            this.Load += new System.EventHandler(this.ProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}