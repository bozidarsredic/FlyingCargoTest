namespace WindowsFormsApp
{
    partial class ReadProductForm
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

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnRead;

        private void InitializeComponent()
        {
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtProductId
            this.txtProductId.Location = new System.Drawing.Point(12, 12);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(260, 20);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.Text = "Product ID";

            // btnRead
            this.btnRead.Location = new System.Drawing.Point(12, 38);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(260, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read Product";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);

            // ReadProductForm
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtProductId);
            this.Name = "ReadProductForm";
            this.Text = "Read Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
