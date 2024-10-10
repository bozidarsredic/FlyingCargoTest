namespace WindowsFormsApp
{
    partial class FilterQuantityProductForm
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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // txtFrom
            this.txtFrom.Location = new System.Drawing.Point(12, 12);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Text = "From";

            // txtTo
            this.txtTo.Location = new System.Drawing.Point(118, 12);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.Text = "To";

            // btnFilter
            this.btnFilter.Location = new System.Drawing.Point(224, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            // listBoxProducts
            this.listBoxProducts.Location = new System.Drawing.Point(12, 39);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(287, 394);
            this.listBoxProducts.TabIndex = 3;

            // FilterQuantityProductForm
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "FilterQuantityProductForm";
            this.Text = "Filter Quantity Products";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}
