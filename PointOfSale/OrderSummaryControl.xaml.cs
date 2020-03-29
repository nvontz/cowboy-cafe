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
        /// <summary>
        /// Allows user to access customiztion through the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is ListView list)
                {
                    if (list.SelectedValue is IOrderItem item)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        if (orderControl == null) throw new Exception("An Ancestor was not found");
                        var screen = new FrameworkElement();
                        
                        switch(item)
                        {
                            case AngryChicken chicken:
                                screen = new CustomizeAngryChicken();
                                break;
                            case CowpokeChili chili:
                                screen = new CustomizeCowpokeChili();
                                break;
                            case TrailBurger burger:
                                screen = new CustomizeTrailBurger();
                                break;
                            case DakotaDoubleBurger burger:
                                screen = new CustomizeDakotaDoubleBurger();
                                break;
                            case PecosPulledPork Pork:
                                screen = new CustomizePekosPulledPork();
                                break;
                            case Water water:
                                screen = new CustomizeWater();
                                break;
                            case JerkedSoda soda:
                                screen = new CustomizeJerkedSoda();
                                break;
                            case TexasTea tea:
                                screen = new CustomizeTexasTea();
                                break;
                            case CowboyCoffee coffee:
                                screen = new CustomizeCowboyCoffee();
                                break;
                            case TexasTripleBurger burger:
                                screen = new CustomizeTexasTripleBurger();
                                break;
                            case Side side:
                                screen = new CustomizeSide();
                                break;
                        }
                        screen.DataContext = item;
                        orderControl.SwapScreen(screen);

                    }
                }
            }
        }
        /// <summary>
        /// Allows user to remove item from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
