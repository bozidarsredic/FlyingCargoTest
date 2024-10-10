namespace WindowsFormsApp
{
    partial class DeleteProductForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtProductId
            this.txtProductId.Location = new System.Drawing.Point(12, 12);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(260, 20);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.Text = "Product ID";

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(12, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DeleteProductForm
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProductId);
            this.Name = "DeleteProductForm";
            this.Text = "Delete Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnDelete;
    }
}
