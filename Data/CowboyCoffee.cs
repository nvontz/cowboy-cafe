using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public bool decaf = false;
        public bool Decaf 
        {
            get { return decaf; }
            set { decaf = value; }
        
        }

        public bool roomforcream = false;

        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }

        public  bool ice = false;

        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        } 

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (decaf) instructions.Add("Decaf");
                if (roomforcream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
