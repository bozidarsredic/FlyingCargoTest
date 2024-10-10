namespace WindowsFormsApp
{
    partial class UpdateProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Definišemo potrebna polja
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.Button btnUpdate;

        private void InitializeComponent()
        {
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtProductId
            this.txtProductId.Location = new System.Drawing.Point(12, 12);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(260, 20);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.Text = "Product ID";

            // txtProductName
            this.txtProductName.Location = new System.Drawing.Point(12, 38);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(260, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Text = "Product Name";

            // txtProductDescription
            this.txtProductDescription.Location = new System.Drawing.Point(12, 64);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(260, 20);
            this.txtProductDescription.TabIndex = 2;
            this.txtProductDescription.Text = "Product Description";

            // txtProductPrice
            this.txtProductPrice.Location = new System.Drawing.Point(12, 90);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(260, 20);
            this.txtProductPrice.TabIndex = 3;
            this.txtProductPrice.Text = "Product Price";

            // txtStockQuantity
            this.txtStockQuantity.Location = new System.Drawing.Point(12, 116);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(260, 20);
            this.txtStockQuantity.TabIndex = 4;
            this.txtStockQuantity.Text = "Stock Quantity";

            // txtCreatedAt
            this.txtCreatedAt.Location = new System.Drawing.Point(12, 142);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(260, 20);
            this.txtCreatedAt.TabIndex = 6;
            this.txtCreatedAt.Text = "Created At (yyyy-MM-dd)";

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(12, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // UpdateProductForm
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Name = "UpdateProductForm";
            this.Text = "Update Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
