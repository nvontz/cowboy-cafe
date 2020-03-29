/*
 * Author: Nathan Vontz
 * Class: CowpokeChiliPropertyChangedTests.cs
 * Purpose: A class for the Cowpoke Chili Property Changed Tests
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Cowpoke Chili should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Changing the Cheese Property should Invoke PropertyChanged for "Cheese"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = false;
            });
        }
        /// <summary>
        /// Changing the Cheese Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Cheese = false;
            });
        }
        /// <summary>
        /// Changing the Sour Cream Property should Invoke PropertyChanged for "SourCream"
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SourCream", () =>
            {
                item.SourCream = false;
            });
        }
        /// <summary>
        /// Changing the Sour Cream Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.SourCream = false;
            });
        }
        /// <summary>
        /// Changing the Green Onions Property should Invoke PropertyChanged for "GreenOnions"
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "GreenOnions", () =>
            {
                item.GreenOnions = false;
            });
        }
        /// <summary>
        /// Changing the Green Onions Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.GreenOnions = false;
            });
        }
        /// <summary>
        /// Changing the Tortilla Strips Property should Invoke PropertyChanged for "TortillaStrips"
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "TortillaStrips", () =>
            {
                item.TortillaStrips = false;
            });
        }
        /// <summary>
        /// Changing the Tortilla Strips Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.TortillaStrips = false;
            });
        }
    }
}
