﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water: Drink
    {
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
