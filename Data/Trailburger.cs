﻿/*
 * Author: Nathan Vontz
 * Class: Trailburger.cs
 * Purpose: A class to represent the Trailburger entree 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// the price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// the calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger contains ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyofPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger contains mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            { 
                mustard = value;
                NotifyofPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger contains pickles
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
        
        private bool cheese = true;
        /// <summary>
        /// If the burger contains cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            {
                cheese = value;
                NotifyofPropertyChange("Cheese");
            }
        }

        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            {
                bun = value;
                NotifyofPropertyChange("Bun");
            }
        }
        /// <summary>
        /// Special instructions for the preperation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }
        /// <summary>
        /// The String for Trailburger
        /// </summary>
        /// <returns>Trail Burger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
