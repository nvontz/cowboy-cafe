/*
 * Author: Nathan Vontz
 * Class: Water.cs
 * Purpose: A class to repesent the water drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to repesent the water drink
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        /// the price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }
        /// <summary>
        /// the calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public bool lemon = false;
        /// <summary>
        /// if the water has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        /// <summary>
        /// Special Instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" Water");
            return sb.ToString();
            
        }
    }
}
