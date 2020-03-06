/*
 * Author: Nathan Vontz
 * Class: AngryChicken.cs 
 * Purpose: A Class to represent the Angry Chicken entree
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree 
    /// </summary>
    public class AngryChicken : Entree
    {
     
        /// <summary>
        /// The Price of the Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// The Price of the Calories
        /// </summary>
        public override uint Calories
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
            set 
            {
                bread = value;
                NotifyofPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken contains pickles 
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            {
                pickle = value;
                NotifyofPropertyChange("Pickle");
            }
        }
        /// <summary>
        /// Special instructions for the preperation of the Chicken 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
        /// <summary>
        /// To String Method for the angry chicken
        /// </summary>
        /// <returns>Angry Chicken</returns> 
        public override string ToString()
        {
            return "Angry Chicken";
        }

    }
}
