/*
 * Author: Nathan Vontz
 * Class: CustomizeSide.xaml.cs
 * Purpose: The Side Customization Control 
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
    /// Interaction logic for SideCustomization.xaml
    /// </summary>
    public partial class CustomizeSide : UserControl
    {
        public CustomizeSide()
        {
            InitializeComponent();
            SmallButton.Click += SizeChange;
            MediumButton.Click += SizeChange;
            LargeButton.Click += SizeChange;
        }
        /// <summary>
        /// Indicates what Size the User Wants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeChange(object sender, RoutedEventArgs e)
        {

            if(DataContext is Side side)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Small":
                            side.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "Medium":
                            side.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "Large":
                            side.Size = CowboyCafe.Data.Size.Large;
                            break;
                    }

                }
            }

        }
    }
}