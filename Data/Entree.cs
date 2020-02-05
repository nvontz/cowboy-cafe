/*
 * Author: Nathan Vontz
 * Class: Entree.cs
 * Purpose: An abstract base class for the entrees
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract base class to represent the entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The Price of an Entree
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        ///  The Calories of an Entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The Special Insructions for the Entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
