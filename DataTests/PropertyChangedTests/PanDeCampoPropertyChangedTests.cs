/*
 * Author: Nathan Vontz
 * Class: PanDeCampoPropertyChangedTests.cs
 * Purpose: A class for the Pan De Campo Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Pan De Campo should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var item = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void PanDeCampoSizeChangeShouldChangeThePrice()
        {
            var item = new PanDeCampo();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void PanDeCampoSizeChangeShouldChangeTheSize()
        {
            var item = new PanDeCampo();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void PanDeCampoSizeChangeShouldChangeTheCalories()
        {
            var item = new PanDeCampo();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Medium;
            });
        }
    }
}
