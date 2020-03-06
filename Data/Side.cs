﻿/*
 * Author: amandajoelleyoung
 * Edited By: Nathan Vontz
 * Class: Side.cs
 * Purpose: Am abstract base class represnting a side 
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : INotifyPropertyChanged, IOrderItem
    {

        /// <summary>
        /// The Property Changed event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

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
