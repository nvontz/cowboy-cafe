using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        /// <summary>
        /// Initializes the Cashdrawer
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        public CashControl()
        {
            InitializeComponent();
        }

        private void Penny_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Penny, 1);
        }

        private void Nickel_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Nickel, 1);
        }

        private void Dime_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Dime, 1);
        }

        private void Quarter_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Quarter, 1);
        }

        private void HalfDollar_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.HalfDollar, 1);
        }

        private void DollarCoin_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddCoin(Coins.Dollar, 1);
        }

        private void DollarBill_Click(object sender, RoutedEventArgs e)
        {
            drawer.AddBill(Bills.One, 1);
        }
    }
}
