/*
 * Author: Nathan Vontz
 * Class: CornDodgersPropertyChangedTests.cs
 * Purpose: A class for the Corn Dodgers Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgerPropertyChangedTests
    {
        /// <summary>
        /// CornDodgers should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var item = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void CornDodgersSizeChangeShouldChangeThePrice()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void CornDodgersSizeChangeShouldChangeTheSize()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Size Changes with Size
        /// </summary>
        [Fact]
        public void CornDodgersSizeChangeShouldChangeTheCalories()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Medium;
            });
        }
    }
}
