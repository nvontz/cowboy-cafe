﻿/*
 * Author: Nathan Vontz
 * Class: CornDodgers.cs
 * Purpose: A Class to represent the CornDogers side
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class to represent the Corn Dodgers Side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The Calories of the Corn Dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// The Price of the Corn Dodgers
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


    }
}
