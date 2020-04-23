using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The calories of this order item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// The price of this order items
        /// </summary>
       double Price { get; }
        /// <summary>
        /// the special instuctions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
