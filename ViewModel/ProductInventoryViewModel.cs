using ECommerceShipping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ECommerceShipping.ViewModel
{
    public class ProductInventoryViewModel : INotifyPropertyChanged
    {
        private DateTime _orderDate;

        public List<ProductViewModel> Products { get; set; }
        public ProductInventory ProductInventory { get; set; }

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                NotifyPropertyChanged();
                UpdateShipDates();
            }
        }

        public ProductInventoryViewModel()
        {
            ProductInventory = new ProductInventory();
            LoadProducts(ProductInventory.Products);
        }

        private void LoadProducts(List<Product> products)
        {
            Products = new List<ProductViewModel>();
            foreach (Product product in products)
            {
                Products.Add(new ProductViewModel(product));
            }
            OrderDate = DateTime.Today;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateShipDates()
        {
            foreach (ProductViewModel productVM in Products)
            {
                if (productVM.IsSelected)
                {
                    productVM.CalculateShipDate(OrderDate);
                }
            }
        }
    }
}
