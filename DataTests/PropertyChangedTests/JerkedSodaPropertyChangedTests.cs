/*
 * Author: Nathan Vontz
 * Class: JerkedSodaPropertyChangedTests.cs
 * Purpose: A class for the Jerked Soda Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Jerked Soda should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var item = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void JerkedSodaSizeChangeShouldChangeThePrice()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void JerkedSodaSizeChangeShouldChangeTheSize()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void JerkedSodaSizeChangeShouldChangeTheCalories()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Changing the Flavor Property should Invoke PropertyChanged for "Flavor"
        /// </summary>
        [Fact]
        public void ChangingFalvorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Flavor", () =>
            {
                item.Flavor = SodaFlavor.OrangeSoda;
            });
        }
        /// <summary>
        /// Changing the Ice Property should Invoke PropertyChanged for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = false;
            });
        }
        /// <summary>
        /// Changing the Ice Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = false;
            });
        }
    }
}
