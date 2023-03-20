using ECommerceShipping.ViewModel;
using System;
using System.Windows;

namespace ECommerceShipping.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ProductInventoryViewModel();
        }
    }
}
