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

namespace PointOfSale.CustomizeDrink
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
            SmallButton.Click += SizeChange;
            MediumButton.Click += SizeChange;
            LargeButton.Click += SizeChange;
            BirchBeerButton.Click += FlavorChange;
            RootBeerButton.Click += FlavorChange;
            CreamSodaButton.Click += FlavorChange;
            OrangeSodaButton.Click += FlavorChange;
            SarsparillaButton.Click += FlavorChange;
        }
        /// <summary>
        /// Changes the size of the drink
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
        /// <summary>
        /// Changes the Flavor of the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorChange(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Birch":
                            soda.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "Cream":
                            soda.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "Orange":
                            soda.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "Root":
                            soda.Flavor = SodaFlavor.RootBeer;
                            break;
                        case "Sarsparilla":
                            soda.Flavor = SodaFlavor.Sarsparilla;
                            break;
                    }
                }
            }
        }
    }
}
