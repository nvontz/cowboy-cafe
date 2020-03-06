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
                            order.Add(new TexasTea());
                            orderControl.SwapScreen(new CustomizeTexasTea());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            orderControl.SwapScreen(new CustomizeCowboyCoffee());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            orderControl.SwapScreen(new CustomizeAngryChicken());
                            break;
                        case "RustlersRibs":
                            order.Add(new RustlersRibs());
                            orderControl.SwapScreen(new CustomizeRustlerRibs());
                            break;
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "PandeCampo":
                            order.Add(new PanDeCampo());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            orderControl.SwapScreen(new CustomizeSide());
                            break;

                    }
                }
            }
        }

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
    }
}
