using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class DeleteProductForm : Form
    {
        private readonly HttpClient _httpClient;

        public DeleteProductForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44366/v1/Product/");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int productId;
            // Proverava da li je uneti ID validan broj
            if (!int.TryParse(txtProductId.Text, out productId))
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }

            // Slanje DELETE zahteva ka API-ju
            var response = await _httpClient.DeleteAsync(productId.ToString());

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product deleted successfully!");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error deleting product: {errorContent}");
            }
        }
    }
}
