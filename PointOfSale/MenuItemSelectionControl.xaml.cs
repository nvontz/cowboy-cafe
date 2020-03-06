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
using CowboyCafe.Extensions;
using PointOfSale.CustomizeDrink;
using PointOfSale.CustomizeEntree;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initailizer for MenuItemSelectionControl 
        /// </summary>
        public MenuItemSelectionControl()
        {
            {
                InitializeComponent();              
                AddCowpokeChiliButton.Click += OnItemAddButtonClicked; ;
                AddWaterButton.Click += OnItemAddButtonClicked;
                AddTexasTeaButton.Click += OnItemAddButtonClicked;
                AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;
                AddRustlersRibsButton.Click += OnItemAddButtonClicked;
                AddPekosPulledPorkButton.Click += OnItemAddButtonClicked;
                AddTrailBurgerButton.Click += OnItemAddButtonClicked;
                AddDakotaDoubleBurgerButton.Click += OnItemAddButtonClicked;
                AddTexasTripleBurgerButton.Click += OnItemAddButtonClicked;
                AddAngryChickenButton.Click += OnItemAddButtonClicked;
                AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;
                AddCornDodgersButton.Click += OnItemAddButtonClicked;
                AddPanDeCampoButton.Click += OnItemAddButtonClicked;
                AddBakedBeansButton.Click += OnItemAddButtonClicked;
                AddJerkedSodaButton.Click += OnItemAddButtonClicked;
            }
        }
        /// <summary>
        /// Actions for where an item button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if(sender is Button button)
                {

                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            AddItemAndOpenCustomizationScreen(new CowpokeChili(), new CustomizeCowpokeChili());
                            break;
                        case "Trailburger":
                            AddItemAndOpenCustomizationScreen(new TrailBurger(), new CustomizeTrailBurger());
                            break;
                        case "DakotaDoubleBurger":
                            AddItemAndOpenCustomizationScreen(new DakotaDoubleBurger(), new CustomizeDakotaDoubleBurger());
                            break;                   
                        case "PekosPulledPork":
                            AddItemAndOpenCustomizationScreen(new PecosPulledPork(), new CustomizePekosPulledPork());
                            break;
                        case "Water":
                            AddItemAndOpenCustomizationScreen(new Water(), new CustomizeWater());
                            break;
                        case "JerkedSoda":
                            AddItemAndOpenCustomizationScreen(new JerkedSoda(), new CustomizeJerkedSoda());
                            break;
                        case "TexasTea":
                            AddItemAndOpenCustomizationScreen(new TexasTea(), new CustomizeTexasTea());
                            break;
                        case "CowboyCoffee":
                            AddItemAndOpenCustomizationScreen(new CowboyCoffee(), new CustomizeCowboyCoffee());
                            break;
                        case "AngryChicken":
                            AddItemAndOpenCustomizationScreen(new AngryChicken(), new CustomizeAngryChicken());
                            break;
                        case "RustlersRibs":
                            AddItemAndOpenCustomizationScreen(new RustlersRibs(), null);
                            break;
                        case "TexasTripleBurger":
                            AddItemAndOpenCustomizationScreen(new TexasTripleBurger(), new CustomizeTexasTripleBurger());
                            break;
                        case "CornDodgers":
                            AddItemAndOpenCustomizationScreen(new CornDodgers(), new CustomizeSide());
                            break;
                        case "ChiliCheeseFries":
                            AddItemAndOpenCustomizationScreen(new ChiliCheeseFries(), new CustomizeSide());
                            break;
                        case "PandeCampo":
                            AddItemAndOpenCustomizationScreen(new PanDeCampo(), new CustomizeSide());
                            break;
                        case "BakedBeans":
                            AddItemAndOpenCustomizationScreen(new BakedBeans(), new CustomizeSide());
                            break;

                    }
                }
            }
        }
        /// <summary>
        /// Helper method that switches screens and adds items to the list
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        public void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext should be an Order instance");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An Ancestor was not found");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }

        public void SetSize()
        {

        }
    }
}
