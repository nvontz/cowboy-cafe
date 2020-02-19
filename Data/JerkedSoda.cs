/*
 * Author: Nathan Vontz
 * Class: JerkedSoda.cs
 * Purpse: A class to represent the Jerked Soda drink 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// the calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// Special Instructions for the shoes
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" ");
            sb.Append(Flavor);
            sb.Append(" Jerked Soda");
            return sb.ToString();

        }
    }
}
