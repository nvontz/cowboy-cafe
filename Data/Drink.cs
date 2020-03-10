/*
 * Author: Nathan Vontz
 * Class: Drink.cs
 * Purpose: An abstract class to represent a drink
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// An Abstract class to represent a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
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

        private Size size;
        /// <summary>
        /// gets the size for the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// sets Ice in the drink to be true by default
        /// </summary>
        public virtual bool Ice 
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyofPropertyChange("Ice");
            }
             
        }

        /// <summary>
        /// Helper method to notify of boolean customization properties 
        /// </summary>
        /// <param name="property"></param>
        protected void NotifyofPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
