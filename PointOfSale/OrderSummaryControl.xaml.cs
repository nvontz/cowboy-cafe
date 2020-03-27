/*
 * Author: Nathan Vontz
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: The Order Menu for the Restaurant 
 */

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
using CowboyCafe.Data;
using CowboyCafe.Extensions;
using PointOfSale.CustomizeDrink;
using PointOfSale.CustomizeEntree;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// The Initailizer for the class
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is IOrderItem item)
            {
                var orderControl = this.FindAncestor<OrderControl>();
              
            }  
        }

        private void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
