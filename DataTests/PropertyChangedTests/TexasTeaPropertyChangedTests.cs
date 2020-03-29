/*
 * Author: Nathan Vontz
 * Class: TexasTeaPropertyChangedTests.cs
 * Purpose: A class for the Texas Tea Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        /// <summary>
        /// Texas Tea should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var item = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void TexasTeaSizeChangeShouldChangeThePrice()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void TexasTeaSizeChangeShouldChangeTheSize()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void TexasTeaSizeChangeShouldChangeTheCalories()
        {
            var item = new TexasTea();
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
            var item = new TexasTea();
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
            var item = new TexasTea();
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
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = false;
            });
        }
        /// <summary>
        /// Changing the Lemon Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lemon = false;
            });
        }
        /// <summary>
        /// Changing the Sweet Property should Invoke PropertyChanged for "Sweet"
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Sweet = false;
            });
        }
    }
}
