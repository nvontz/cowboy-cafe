/*
 * Author: Nathan Vontz
 * Class: BakedBeansPropertyChangedTests.cs
 * Purpose: A class for the Baked Beans Property Changed Tests
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Baked Beans should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }
        /// <summary>
        /// Checks to see if Price Changes with Size
        /// </summary>
        [Fact]
        public void BakedBeansSizeChangeShouldChangeThePrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Medium;
            });
        }

        /// <summary>
        /// Checks to see if Size Changes with Size Change
        /// </summary>
        [Fact]
        public void BakedBeansSizeChangeShouldChangeTheSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Medium;
            });
        }
        /// <summary>
        /// Checks to see if Calories Changes with Size Change
        /// </summary>
        [Fact]
        public void BakedBeansSizeChangeShouldChangeTheCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Medium;
            });
        }
    }
}
