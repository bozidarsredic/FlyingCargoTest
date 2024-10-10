using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    public partial class UpdateProductForm : Form
    {
        private readonly HttpClient _httpClient;

        public UpdateProductForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44366/v1/Product/");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kreiramo objekt za ažuriranje proizvoda
            var updateData = new
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                Description = txtProductDescription.Text,
                Price = txtProductPrice.Text,
                StockQuantity = txtStockQuantity.Text,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd") // Formatiran datum u yyyy-MM-dd
            };

            // Serijalizujemo podatke u JSON format
            var jsonData = new StringContent(JsonConvert.SerializeObject(updateData), Encoding.UTF8, "application/json");

            // Kreiramo PATCH zahtev
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), "update")
            {
                Content = jsonData
            };

            // Šaljemo zahtev
            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error updating product: {errorContent}");
            }
        }
    }
}
