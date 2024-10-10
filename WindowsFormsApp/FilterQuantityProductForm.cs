using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FilterQuantityProductForm : Form
    {
        private readonly HttpClient _httpClient;

        public FilterQuantityProductForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44366/v1/Product/");
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int from) && int.TryParse(txtTo.Text, out int to))
            {
                var products = await GetFilteredProducts(from, to);
                listBoxProducts.Items.Clear();

                foreach (var product in products)
                {
                    listBoxProducts.Items.Add(product.ProductName);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private async Task<List<Product>> GetFilteredProducts(int from, int to)
        {
            var response = await _httpClient.GetAsync($"filter/{from}/{to}");

            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadAsAsync<List<Product>>();
                return products;
            }

            MessageBox.Show("Error retrieving products.");
            return new List<Product>();
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
    }
}
