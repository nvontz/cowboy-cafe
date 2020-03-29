/*
 * Author: Nathan Vontz
 * Class: ChiliCheeseFriesPropertyChangedTests.cs
 * Purpose: A class for the Chili Cheese Fries Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        
        /// <summary>
        /// ChiliCheeseFries should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesSizeChangeShouldChangeThePrice()
        {
            var Fries = new ChiliCheeseFries();
            Assert.PropertyChanged(Fries, "Price", () =>
            {
                Fries.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesSizeChangeShouldChangeTheSize()
        {
            var Fries = new ChiliCheeseFries();
            Assert.PropertyChanged(Fries, "Size", () =>
            {
                Fries.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Calories Changes with Size
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesSizeChangeShouldChangeTheCalories()
        {
            var Fries = new ChiliCheeseFries();
            Assert.PropertyChanged(Fries, "Calories", () =>
            {
                Fries.Size = Size.Medium;
            });
        }
    }
}
