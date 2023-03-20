using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Products.Add(
                new Product
                {
                    ProductId = 1,
                    ProductName = "fugiat exercitation adipisicing",
                    InventoryQuantity = 43,
                    ShipOnWeekends = true,
                    MaxBusinessDaysToShip = 13
                });
            Products.Add(
                new Product
                {
                    ProductId = 2,
                    ProductName = "mollit cupidatat Lorem",
                    InventoryQuantity = 70,
                    ShipOnWeekends = true,
                    MaxBusinessDaysToShip = 18
                });
            Products.Add(
                new Product
                {
                    ProductId = 3,
                    ProductName = "non quis sint",
                    InventoryQuantity = 33,
                    ShipOnWeekends = false,
                    MaxBusinessDaysToShip = 15
                });
            Products.Add(
                new Product
                {
                    ProductId = 4,
                    ProductName = "voluptate cupidatat non",
                    InventoryQuantity = 52,
                    ShipOnWeekends = false,
                    MaxBusinessDaysToShip = 18
                });
            Products.Add(
                new Product
                {
                    ProductId = 5,
                    ProductName = "anim amet occaecat",
                    InventoryQuantity = 39,
                    ShipOnWeekends = true,
                    MaxBusinessDaysToShip = 19
                });
            Products.Add(
                new Product
                {
                    ProductId = 6,
                    ProductName = "cillum deserunt elit",
                    InventoryQuantity = 47,
                    ShipOnWeekends = false,
                    MaxBusinessDaysToShip = 20
                });
            Products.Add(
                new Product
                {
                    ProductId = 7,
                    ProductName = "adipisicing reprehenderit et",
                    InventoryQuantity = 71,
                    ShipOnWeekends = false,
                    MaxBusinessDaysToShip = 15
                });
            Products.Add(
                new Product
                {
                    ProductId = 8,
                    ProductName = "ex mollit laboris",
                    InventoryQuantity = 80,
                    ShipOnWeekends = false,
                    MaxBusinessDaysToShip = 15
                });
        }
    }
}
