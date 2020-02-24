/*
 * Author: Nathan Vontz
 * Class: TexasTea.cs
 * Purpose: A class to represent the texas tea drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// The Price of the Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The Calories of the Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        public bool lemon = false;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public bool sweet = true;
        /// <summary>
        /// If the tea is sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        /// <summary>
        /// Special Instructions for the Tea
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
        /// <summary>
        /// Gets the String for the Texas Tea
        /// </summary>
        /// <returns>(Size) Texas (Type) Tea</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" Texas");
            if (Sweet) sb.Append(" Sweet");
            else sb.Append(" Plain");
            sb.Append(" Tea");
            return sb.ToString();
        }
    }
}
