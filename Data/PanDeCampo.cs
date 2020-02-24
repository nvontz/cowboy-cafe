﻿/*
 * Author: Nathan Vontz
 * Class: PanDeCampo.cs
 * Purpose: A Class representing the Pan De Campo Side
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Pan De Campo side
    /// </summary>
    public class PanDeCampo: Side
    { 
        /// <summary>
        /// The Calories of the Pan De Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// The Price of the Pan De Campo 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// Gets the String for the Pan de Campo
        /// </summary>
        /// <returns>(Size) Pand de Campo</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" Pan de Campo");
            return sb.ToString();

        }

    }
}
