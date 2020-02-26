/*
 * Author: Nathan Vontz
 * Class: Drink.cs
 * Purpose: An abstract class to represent a drink
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An Abstract class to represent a drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// the price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// gets the size for the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// sets Ice in the drink to be true by default
        /// </summary>
        public virtual bool Ice { get; set; } = true;

    }
}
