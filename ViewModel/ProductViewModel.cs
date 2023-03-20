using ECommerceShipping.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ECommerceShipping.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private Product _product;
        private DateTime _shipDate;

        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime ShipDate
        {
            get { return _shipDate; }
            set
            {
                _shipDate = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsSelected { get; set; }

        public ProductViewModel(Product product)
        {
            Product = product;
            CalculateShipDate(DateTime.Today);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CalculateShipDate(DateTime orderDate)
        {
            _ = new ShippingDateCalculator();
            ShipDate = ShippingDateCalculator.CalculateShippingDate(orderDate, Product);
        }
    }

    

}
