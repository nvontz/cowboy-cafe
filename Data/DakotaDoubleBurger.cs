/*
 * Author: Nathan Vontz
 * Class: DakotaDoubleBurger.cs
 * Purpose: A class to represent the Dakota Double Burger entree
 */



using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// the Price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// the Calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
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
                NotifyofPropertyChange("ketchup");
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
                NotifyofPropertyChange("mustard");
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
                NotifyofPropertyChange("pickle");
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
                NotifyofPropertyChange("cheese");
            }
        }
        private bool tomato = true;
        /// <summary>
        /// If the burger is topped with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            {
                tomato = value;
                NotifyofPropertyChange("tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            {
                lettuce = value;
                NotifyofPropertyChange("lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mayo 
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            {
                mayo = value;
                NotifyofPropertyChange("mayo");
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
                NotifyofPropertyChange("bun");
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
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bun) instructions.Add("hold bun");

                return instructions;
            }
        }
        /// <summary>
        /// To String Method for the Dakota Double Burger
        /// </summary>
        /// <returns>Dakota Double Burger</returns> 
        public override string ToString()
        {
            return "Dakota Double Burger";
        }

    }
}
