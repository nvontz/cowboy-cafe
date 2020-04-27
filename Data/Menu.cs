using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets the Entrees for the Menu
        /// </summary>
        /// <returns>An Array of the Entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
           
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TrailBurger());
            entrees.Add(new TexasTripleBurger());

            return entrees.ToArray();
        }
        /// <summary>
        /// Gets the Sides for the Menu
        /// </summary>
        /// <returns>An Array of the Sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            Side side = new ChiliCheeseFries();
            for(int i = 0; i < 3; i++)
            {
              side = new ChiliCheeseFries();
              if (i == 0) side.Size = Size.Small;
              if (i == 1) side.Size = Size.Medium;
              if (i == 2) side.Size = Size.Large;
              sides.Add(side);
            }
           
            for (int i = 0; i < 3; i++)
            {
                side = new CornDodgers();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                sides.Add(side);
            }
            
            for (int i = 0; i < 3; i++)
            {
                side = new PanDeCampo();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                sides.Add(side);
            }
          
            for (int i = 0; i < 3; i++)
            {
                side = new BakedBeans();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                sides.Add(side);
            }

            return sides.ToArray();
        }
        /// <summary>
        /// Gets the Drinks for the Menu
        /// </summary>
        /// <returns>An Array of the Drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            Drink drink = new CowboyCoffee();
            for (int i = 0; i < 3; i++)
            {
                drink = new JerkedSoda();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                drinks.Add(drink);
            }
            for (int i = 0; i < 3; i++)
            {
                drink = new TexasTea();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                drinks.Add(drink);
            }
            for (int i = 0; i < 3; i++)
            {
                drink = new CowboyCoffee();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                drinks.Add(drink);
            }

            for (int i = 0; i < 3; i++)
            {
                drink = new Water();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                drinks.Add(drink);
            }

            return drinks.ToArray();
        }
        /// <summary>
        /// Gets the Complete Menu for the Restaurant 
        /// </summary>
        /// <returns>An Array of the Menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TrailBurger());
            menu.Add(new TexasTripleBurger());

            Side side = new CornDodgers();
            for (int i = 0; i < 3; i++)
            {
                side = new ChiliCheeseFries();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                menu.Add(side);
            }
            for (int i = 0; i < 3; i++)
            {
                side = new CornDodgers();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                menu.Add(side);
            }
            for (int i = 0; i < 3; i++)
            {
                side = new PanDeCampo();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                menu.Add(side);
            }

            for (int i = 0; i < 3; i++)
            {
                side = new BakedBeans();
                if (i == 0) side.Size = Size.Small;
                if (i == 1) side.Size = Size.Medium;
                if (i == 2) side.Size = Size.Large;
                menu.Add(side);
            }

            Drink drink = new CowboyCoffee();
            for (int i = 0; i < 3; i++)
            {
                drink = new JerkedSoda();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                menu.Add(drink);
            }
            for (int i = 0; i < 3; i++)
            {
                drink = new TexasTea();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                menu.Add(drink);
            }
            for (int i = 0; i < 3; i++)
            {
                drink = new CowboyCoffee();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                menu.Add(drink);
            }

            for (int i = 0; i < 3; i++)
            {
                drink = new Water();
                if (i == 0) drink.Size = Size.Small;
                if (i == 1) drink.Size = Size.Medium;
                if (i == 2) drink.Size = Size.Large;
                menu.Add(drink);
            }

            return menu.ToArray();
        }
        /// <summary>
        /// A Property that gets All items in the Menu
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return CompleteMenu(); } }
        /// <summary>
        /// Method that Searches the menu with what the user inputted
        /// </summary>
        /// <param name="terms"></param>
        /// <returns>returns the items matching the search requirements</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return All;

            foreach(IOrderItem item in All)
            {
                if(item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// String Array that Containes Each Category
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }
        /// <summary>
        /// Filters the items by selected Category
        /// </summary>
        /// <param name="items">the items being searched</param>
        /// <param name="category">the cateogries that are being used</param>
        /// <returns>The items within the respective category</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(category.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                if (category.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
                if (category.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// Filters the items by selected Calories
        /// </summary>
        /// <param name="items">the items being searched</param>
        /// <param name="min">min cal</param>
        /// <param name="max">max cal</param>
        /// <returns>The items after they're filtered</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                   if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                   if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
               if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }

            return results;
        }
        /// <summary>
        /// Filters the items by Price
        /// </summary>
        /// <param name="items">the items being searched</param>
        /// <param name="min">min price</param>
        /// <param name="max">max price</param>
        /// <returns>the items after they're filtered</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                   if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {                 
                  if (item.Price >= min) results.Add(item);                   
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max) results.Add(item);
            }
            return results;
        }
    }
}
