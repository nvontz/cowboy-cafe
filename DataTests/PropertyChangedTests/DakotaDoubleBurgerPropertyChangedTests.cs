﻿/*
 * Author: Nathan Vontz
 * Class: DakotaDoubleBurgerPropertyChangedTests.cs
 * Purpose: A class for the Dakota Double Burger Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Dakota Double Burger should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Changing the Ketchup Property should Invoke PropertyChanged for "Ketchup"
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Cheese = false;
            });
        }
        /// <summary>
        /// Changing the Tomato Property should Invoke PropertyChanged for "Tomato"
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Tomato", () =>
            {
                item.Tomato = false;
            });
        }
        /// <summary>
        /// Changing the Tomato Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Tomato = false;
            });
        }
        /// <summary>
        /// Changing the Lettuce Property should Invoke PropertyChanged for "Lettuce"
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Lettuce", () =>
            {
                item.Lettuce = false;
            });
        }
        /// <summary>
        /// Changing the Lettuce Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lettuce = false;
            });
        }
        /// <summary>
        /// Changing the Mayo Property should Invoke PropertyChanged for "Mayo"
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Mayo", () =>
            {
                item.Mayo = false;
            });
        }
        /// <summary>
        /// Changing the Mayo Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Mayo = false;
            });
        }
        /// <summary>
        /// Changing the Bun Property should Invoke PropertyChanged for "Bun"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var item = new DakotaDoubleBurger();
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
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bun = false;
            });
        }
    }
}
