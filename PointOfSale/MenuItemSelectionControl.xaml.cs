/*
 * Author: Nathan Vontz
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: The Order Menu items for the Restaurant 
 */

using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {

            {
                InitializeComponent();
                AddCowpokeChiliButton.Click += AddCowpokeChiliButton_Click;
                AddWaterButton.Click += AddWaterButton_Click;
                AddTexasTeaButton.Click += AddTexasTeaButton_Click;
                AddCowboyCoffeeButton.Click += AddCowboyCoffeeButton_Click;
                AddRustlersRibsButton.Click += AddRustlersRibsButton_Click;
                AddPekosPulledPorkButton.Click += AddPekosPulledPorkButton_Click;
                AddTrailBurgerButton.Click += AddTrailBurgerButton_Click;
                AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButton_Click;
                AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButton_Click;
                AddAngryChickenButton.Click += AddAngryChickenButton_Click;
                AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButton_Click;
                AddCornDodgersButton.Click += AddCornDodgersButton_Click;
                AddPanDeCampoButton.Click += AddPanDeCampoButton_Click;
                AddBakedBeansButton.Click += AddBakedBeansButton_Click;
                AddJerkedSodaButton.Click += AddJerkedSodaButton_Click;
            }
        }
        /// <summary>
        /// The Cowpoke Chili Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }
        /// <summary>
        /// The Water Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }

        }
        /// <summary>
        /// The Texas Tea Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }
        /// <summary>
        /// The Cowboy Coffee Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }
        /// <summary>
        /// The Pekos Pulled Pork Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPekosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }
        /// <summary>
        /// The Trail Burger Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }
        /// <summary>
        /// The Dakota Double Burger Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }
        /// <summary>
        /// The Texas Triple Burger Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }
        /// <summary>
        /// The Angry Chicken Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }
        /// <summary>
        /// the Rustler's Ribs Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }
        /// <summary>
        /// The Chili Cheese Fries Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// The Pan De Campo Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// The Baked Beans Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }
        /// <summary>
        /// The Corn Dodgers Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }
        /// <summary>
        /// The Jerked Soda Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }



    }
}
