﻿/*
 * Author: amandajoelleyoung
 * Edited By: Nathan Vontz
 * Class: Side.cs
 * Purpose: Am abstract base class represnting a side 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
    }
}
