using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger
    {
        private bool bacon = true;
        /// <summary>
        /// If the burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true; 
        /// <summary>
        /// If the burger has eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { Egg = value; }
        }
        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }
        /// <summary>
        /// Special instructions for the preperations of the burger 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
             
                return instructions;
            }
        }
    }
}
