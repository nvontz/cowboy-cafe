/*
 * Author: Nathan Vontz
 * Class: CowboyCoffeePropertyChangedTests.cs
 * Purpose: A class for the Cowboy Coffee Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Cowboy Coffee should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void CowboyCoffeeSizeChangeShouldChangeThePrice()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void CowboyCoffeeSizeChangeShouldChangeTheSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void CowboyCoffeeSizeChangeShouldChangeTheCalories()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Changing the Decaf Property should Invoke PropertyChanged for "Decaf"
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Decaf", () =>
            {
                item.Decaf = true;
            });
        }
        /// <summary>
        /// Changing the Decaf Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Decaf = true;
            });
        }
        /// <summary>
        /// Changing the RoomForCream Property should Invoke PropertyChanged for "RoomForCream"
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "RoomForCream", () =>
            {
                item.RoomForCream = true;
            });
        }
        /// <summary>
        /// Changing the RoomForCream Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.RoomForCream = true;
            });
        }
        /// <summary>
        /// Changing the Ice Property should Invoke PropertyChanged for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = true;
            });
        }
        /// <summary>
        /// Changing the Ice Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = true;
            });
        }

    }
}
