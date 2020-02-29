﻿/*
 * Author: Nathan Vontz
 * Class: OrderControl.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// The Constuctor for the Order Control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            this.DataContext = new Order();

            CancelOrderButton.Click += CancelOrderButton_Click;
            CompleteOrderButton.Click += CompleteOrderButton_Click;
        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
          
        }
    }
}
