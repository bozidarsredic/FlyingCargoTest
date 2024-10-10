using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;

        public MainForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44366/v1/Product/"); // Osnovni URL API-ja
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            // Kreiranje form-data zahteva
            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(txtProductName.Text), "ProductName");
            formData.Add(new StringContent(txtProductDescription.Text), "Description");
            formData.Add(new StringContent(txtProductPrice.Text), "Price");
            formData.Add(new StringContent(txtStockQuantity.Text), "StockQuantity");
            formData.Add(new StringContent(DateTime.Parse(txtCreatedAt.Text).ToString("yyyy-MM-dd")), "CreatedAt");

            // Slanje POST zahteva ka API-ju
            var response = await _httpClient.PostAsync("create", formData);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product created successfully!");
            }
            else
            {
                // Prikaži tačan razlog greške
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error creating product: {errorContent}");
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ReadProductForm readProductForm = new ReadProductForm();
            readProductForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteProductForm deleteProductForm = new DeleteProductForm();
            deleteProductForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterQuantityProductForm filterProductForm = new FilterQuantityProductForm();
            filterProductForm.Show();
        }
    }
}
