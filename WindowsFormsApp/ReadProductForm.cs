using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ReadProductForm : Form
    {
        private readonly HttpClient _httpClient;

        public ReadProductForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44366/v1/Product/");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(txtProductId.Text, out productId))
            {
                MessageBox.Show("Invalid Product ID");
                return;
            }

            var response = await _httpClient.GetAsync($"{productId}");

            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Product details: {product}");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error reading product: {errorContent}");
            }
        }
    }
}
