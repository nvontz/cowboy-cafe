/*
 * Author: Nathan Vontz
 * Class: TrailbugerPropertyChangedTests.cs
 * Purpose: A class for the TrailBurger Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailburgerPropertyChangedTests
    {
        /// <summary>
        /// TrailBurger should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Changing the Ketchup Property should Invoke PropertyChanged for "Ketchup"
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Ketchup", () =>
            {
                item.Ketchup = false; ;
            });
        }
        /// <summary>
        /// Changing the Ketchup Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ketchup = false;
            });
        }
        /// <summary>
        /// Changing the Mustard Property should Invoke PropertyChanged for "Mustard"
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Mustard", () =>
            {
                item.Mustard = false; ;
            });
        }
        /// <summary>
        /// Changing the Mustard Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Mustard = false;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = false; ;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Pickle = false;
            });
        }
        /// <summary>
        /// Changing the Cheese Property should Invoke PropertyChanged for "Cheese"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = false; ;
            });
        }
        /// <summary>
        /// Changing the Cheese Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Cheese = false;
            });
        }
        /// <summary>
        /// Changing the Bun Property should Invoke PropertyChanged for "Bun"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Bun", () =>
            {
                item.Bun = false;
            });
        }
        /// <summary>
        /// Changing the Bun Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bun = false;
            });
        }
    }
}
