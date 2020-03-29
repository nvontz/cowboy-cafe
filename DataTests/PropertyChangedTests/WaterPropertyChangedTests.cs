/*
 * Author: Nathan Vontz
 * Class: WaterPropertyChangedTests.cs
 * Purpose: A class for the Water Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Water should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var item = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void WaterSizeChangeShouldChangeThePrice()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void WaterSizeChangeShouldChangeTheSize()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void WaterSizeChangeShouldChangeTheCalories()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Changing the Ice Property should Invoke PropertyChanged for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new Water();
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
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = false;
            });
        }
        /// <summary>
        /// Changing the Lemon Property should Invoke PropertyChanged for "Lemon"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = true;
            });
        }
        /// <summary>
        /// Changing the Lemon Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lemon = true;
            });
        }
    }
}
