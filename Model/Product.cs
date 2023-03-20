using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceShipping.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int InventoryQuantity { get; set; }
        public bool ShipOnWeekends { get; set; }
        public int MaxBusinessDaysToShip { get; set; }
        public string Manufacturer { get; set; }
    }
}
