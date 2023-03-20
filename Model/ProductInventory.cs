using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ECommerceShipping.Model
{
    public class ProductInventory
    {
        public List<Product> Products { get; set; }

        public ProductInventory()
        {
            Products = new List<Product>();
            AddProducts();
        }

        private void AddProducts()
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
