﻿/*
 * Author: Nathan Vontz
 * Class: BakedBeans.cs
 * Purpose: A class for the Baked Beans side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class to represent the Baked Beans Side
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// The Calories of the Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
            
        }
        /// <summary>
        /// The Price of the Beans
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
        /// Retruns size of baked beans
        /// </summary>
        /// <returns>(Size) baked beans</returns> 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Size);
            sb.Append(" Baked Beans");
            return sb.ToString();

        }
    }
}
