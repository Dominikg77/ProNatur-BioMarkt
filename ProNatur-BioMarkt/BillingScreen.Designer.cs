namespace ProNatur_BioMarkt
{
    partial class BillingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBillingFirstname = new System.Windows.Forms.TextBox();
            this.lblBillingFirstname = new System.Windows.Forms.Label();
            this.comboBoxBillingProducts = new System.Windows.Forms.ComboBox();
            this.lblBillingProduct = new System.Windows.Forms.Label();
            this.textBoxBillingPrice = new System.Windows.Forms.TextBox();
            this.lblBillingPrice = new System.Windows.Forms.Label();
            this.btnBillingDelete = new System.Windows.Forms.Button();
            this.btnBillingClear = new System.Windows.Forms.Button();
            this.btnBillingSave = new System.Windows.Forms.Button();
            this.billingDGV = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBoxBillingFirstname
            // 
            this.textBoxBillingFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillingFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillingFirstname.ForeColor = System.Drawing.Color.White;
            this.textBoxBillingFirstname.Location = new System.Drawing.Point(96, 29);
            this.textBoxBillingFirstname.Name = "textBoxBillingFirstname";
            this.textBoxBillingFirstname.Size = new System.Drawing.Size(150, 13);
            this.textBoxBillingFirstname.TabIndex = 3;
            // 
            // lblBillingFirstname
            // 
            this.lblBillingFirstname.AutoSize = true;
            this.lblBillingFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingFirstname.ForeColor = System.Drawing.Color.White;
            this.lblBillingFirstname.Location = new System.Drawing.Point(27, 29);
            this.lblBillingFirstname.Name = "lblBillingFirstname";
            this.lblBillingFirstname.Size = new System.Drawing.Size(56, 13);
            this.lblBillingFirstname.TabIndex = 2;
            this.lblBillingFirstname.Text = "Vorname";
            this.lblBillingFirstname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxBillingProducts
            // 
            this.comboBoxBillingProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxBillingProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBillingProducts.ForeColor = System.Drawing.Color.White;
            this.comboBoxBillingProducts.FormattingEnabled = true;
            this.comboBoxBillingProducts.Items.AddRange(new object[] {
            "Apfel",
            "Birne",
            "Banane"});
            this.comboBoxBillingProducts.Location = new System.Drawing.Point(94, 58);
            this.comboBoxBillingProducts.Name = "comboBoxBillingProducts";
            this.comboBoxBillingProducts.Size = new System.Drawing.Size(125, 21);
            this.comboBoxBillingProducts.TabIndex = 10;
            // 
            // lblBillingProduct
            // 
            this.lblBillingProduct.AutoSize = true;
            this.lblBillingProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingProduct.ForeColor = System.Drawing.Color.White;
            this.lblBillingProduct.Location = new System.Drawing.Point(27, 61);
            this.lblBillingProduct.Name = "lblBillingProduct";
            this.lblBillingProduct.Size = new System.Drawing.Size(51, 13);
            this.lblBillingProduct.TabIndex = 9;
            this.lblBillingProduct.Text = "Produkt";
            this.lblBillingProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBillingPrice
            // 
            this.textBoxBillingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxBillingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBillingPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxBillingPrice.Location = new System.Drawing.Point(96, 85);
            this.textBoxBillingPrice.Name = "textBoxBillingPrice";
            this.textBoxBillingPrice.Size = new System.Drawing.Size(100, 13);
            this.textBoxBillingPrice.TabIndex = 12;
            // 
            // lblBillingPrice
            // 
            this.lblBillingPrice.AutoSize = true;
            this.lblBillingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingPrice.ForeColor = System.Drawing.Color.White;
            this.lblBillingPrice.Location = new System.Drawing.Point(24, 85);
            this.lblBillingPrice.Name = "lblBillingPrice";
            this.lblBillingPrice.Size = new System.Drawing.Size(35, 13);
            this.lblBillingPrice.TabIndex = 11;
            this.lblBillingPrice.Text = "Preis";
            this.lblBillingPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBillingDelete
            // 
            this.btnBillingDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillingDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBillingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingDelete.ForeColor = System.Drawing.Color.White;
            this.btnBillingDelete.Location = new System.Drawing.Point(210, 117);
            this.btnBillingDelete.Name = "btnBillingDelete";
            this.btnBillingDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBillingDelete.TabIndex = 15;
            this.btnBillingDelete.Text = "Löschen";
            this.btnBillingDelete.UseVisualStyleBackColor = false;
            this.btnBillingDelete.Click += new System.EventHandler(this.btnBillingDelete_Click);
            // 
            // btnBillingClear
            // 
            this.btnBillingClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillingClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBillingClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingClear.ForeColor = System.Drawing.Color.White;
            this.btnBillingClear.Location = new System.Drawing.Point(109, 117);
            this.btnBillingClear.Name = "btnBillingClear";
            this.btnBillingClear.Size = new System.Drawing.Size(95, 23);
            this.btnBillingClear.TabIndex = 14;
            this.btnBillingClear.Text = "Felder Leeren";
            this.btnBillingClear.UseVisualStyleBackColor = false;
            this.btnBillingClear.Click += new System.EventHandler(this.btnBillingClear_Click);
            // 
            // btnBillingSave
            // 
            this.btnBillingSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBillingSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBillingSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingSave.ForeColor = System.Drawing.Color.White;
            this.btnBillingSave.Location = new System.Drawing.Point(28, 117);
            this.btnBillingSave.Name = "btnBillingSave";
            this.btnBillingSave.Size = new System.Drawing.Size(75, 23);
            this.btnBillingSave.TabIndex = 13;
            this.btnBillingSave.Text = "Hinzufügen";
            this.btnBillingSave.UseVisualStyleBackColor = false;
            this.btnBillingSave.Click += new System.EventHandler(this.btnBillingSave_Click);
            // 
            // billingDGV
            // 
            this.billingDGV.AllowUserToAddRows = false;
            this.billingDGV.AllowUserToDeleteRows = false;
            this.billingDGV.AllowUserToResizeColumns = false;
            this.billingDGV.AllowUserToResizeRows = false;
            this.billingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billingDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.billingDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDGV.Location = new System.Drawing.Point(12, 187);
            this.billingDGV.MultiSelect = false;
            this.billingDGV.Name = "billingDGV";
            this.billingDGV.ReadOnly = true;
            this.billingDGV.RowHeadersVisible = false;
            this.billingDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.billingDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.billingDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.billingDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.billingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billingDGV.Size = new System.Drawing.Size(775, 262);
            this.billingDGV.TabIndex = 16;
            this.billingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingDGV_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(712, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BillingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.billingDGV);
            this.Controls.Add(this.btnBillingDelete);
            this.Controls.Add(this.btnBillingClear);
            this.Controls.Add(this.btnBillingSave);
            this.Controls.Add(this.textBoxBillingPrice);
            this.Controls.Add(this.lblBillingPrice);
            this.Controls.Add(this.comboBoxBillingProducts);
            this.Controls.Add(this.lblBillingProduct);
            this.Controls.Add(this.textBoxBillingFirstname);
            this.Controls.Add(this.lblBillingFirstname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BillingScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnung";
            ((System.ComponentModel.ISupportInitialize)(this.billingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBillingFirstname;
        private System.Windows.Forms.Label lblBillingFirstname;
        private System.Windows.Forms.ComboBox comboBoxBillingProducts;
        private System.Windows.Forms.Label lblBillingProduct;
        private System.Windows.Forms.TextBox textBoxBillingPrice;
        private System.Windows.Forms.Label lblBillingPrice;
        private System.Windows.Forms.Button btnBillingDelete;
        private System.Windows.Forms.Button btnBillingClear;
        private System.Windows.Forms.Button btnBillingSave;
        private System.Windows.Forms.DataGridView billingDGV;
        private System.Windows.Forms.Button btnBack;
    }
}