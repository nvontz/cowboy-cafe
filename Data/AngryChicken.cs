using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree 
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// The Price of the Chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// The Price of the Calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the chicken contains bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken contains pickles 
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// Special instructions for the preperation of the Chicken 
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

    }
}
