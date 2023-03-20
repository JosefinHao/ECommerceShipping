using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ECommerceShipping.Model
{
    public class ProductInventory
    {
        public List<Product> Products { get; set; }

        public ProductInventory()
        {
            Products = new List<Product>();
            LoadProductInventory();
        }

        private void LoadProductInventory()
        {
            string json = File.ReadAllText("products.json");
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            foreach (Product product in products)
            {
                Products.Add(product);
            }
        }

    }
}
