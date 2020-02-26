using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        /// <summary>
        /// holds the last order number
        /// </summary>
        private static uint lastOrderNumber = 0;
        /// <summary>
        /// the current order number
        /// </summary>
        public uint OrderNumber { get; } = lastOrderNumber++;
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

        public double Subtotal
        {
            get
            {
                return subtotal;
            }
            private set
            {
                subtotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));  
            }
        }
          
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }


    }
}
