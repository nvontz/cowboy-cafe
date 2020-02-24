/*
 * Author: Nathan Vontz
 * Class: CowboyCoffee.cs
 * Purpose: A Class to represent the cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class to represent the cowboy coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// The Calories of the Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public bool decaf = false;
        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf 
        {
            get { return decaf; }
            set { decaf = value; }
        
        }

        public bool roomforcream = false;
        /// <summary>
        /// if the coffee has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }

        public  bool ice = false;
        /// <summary>
        /// if the coffee has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        } 
        /// <summary>
        /// Special Instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (decaf) instructions.Add("Decaf");
                if (roomforcream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
        /// <summary>
        /// Gets the string of the Cowboy Coffee
        /// </summary>
        /// <returns>(Size)(if decaf) Cowboy Coffee</returns> 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            if (decaf) sb.Append(" Decaf");
            sb.Append(" Cowboy Coffee");
            return sb.ToString();
        }
    }
}
