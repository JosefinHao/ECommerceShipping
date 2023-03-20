using ECommerceShipping.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            ShippingDateCalculator calculator = new ShippingDateCalculator();
            ShipDate = calculator.CalculateShippingDate(orderDate, Product);
        }
    }

    

}
