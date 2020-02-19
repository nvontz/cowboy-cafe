/*
 * Author: Nathan Vontz
 * Class: RustlersRibs.cs
 * Purpose: A class to represent the Rustlers Rib entree
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree 
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// the price of the Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// the calories of the Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of the Ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
