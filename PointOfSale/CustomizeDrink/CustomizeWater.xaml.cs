/*
 * Author: Nathan Vontz
 * Class: CustomizeWater.xaml.cs
 * Purpose: The Water Customization Panel
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
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        public CustomizeWater()
        {
            InitializeComponent();
            SmallButton.Click += SizeChange;
            MediumButton.Click += SizeChange;
            LargeButton.Click += SizeChange;
        }
        /// <summary>
        /// Changes the Size of the Drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeChange(object sender, RoutedEventArgs e)
        {

            if (DataContext is Drink drink)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Small":
                            drink.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "Medium":
                            drink.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "Large":
                            drink.Size = CowboyCafe.Data.Size.Large;
                            break;
                    }

                }
            }

        }
    }
}
