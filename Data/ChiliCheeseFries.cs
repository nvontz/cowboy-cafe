/*
 * Author: Nathan Vontz
 * Class: ChiliCheeseFries.cs
 * Purpose: A class to represent the chili cheese fries side
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Chili Cheese Fries Side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The Calories of the Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// The Price of the Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// To String for the chili cheese fries
        /// </summary>
        /// <returns>(Size) Chili Cheese Fries</returns> 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" Chili Cheese Fries");
            return sb.ToString();

        }

    }
}
