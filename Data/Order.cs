/*
 * Author: Nathan Vontz
 * Class: Order.cs
 * Purpose: The Order class for the menu
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Custructor to initialize order
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }
        /// <summary>
        /// holds the last order number
        /// </summary>
        private static uint lastOrderNumber = 0;
        /// <summary>
        /// the current order number
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber; } }
        /// <summary>
        /// A list of the items being ordered
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Holds the IOrderItems to update
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }
        private double subtotal = 0;
        /// <summary>
        /// Gets the subtotal of the selected items
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }
        /// <summary>
        /// constant for the tax price
        /// </summary>
        public const double TAX = 0.16;
        /// <summary>
        /// gets the total with tax
        /// </summary>
        public double total
        {
            get
            {
                return subtotal + subtotal * TAX;
            }
        }

        /// <summary>
        /// Checks if anything has been changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Adds the selected item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            item.PropertyChanged += ItemChange;
            
        }
        /// <summary>
        /// Removes the selected item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            item.PropertyChanged -= ItemChange;
            

        }
        /// <summary>
        /// Keeps track of items change and updates the items dependent on that
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChange(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); 
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        
    }
}
