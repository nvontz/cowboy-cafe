/*
 * Author: Nathan Vontz
 * Class: PecosPulledPorkPropertyChangedTests.cs
 * Purpose: A class for the Pekos Pulled Pork Property Changed Tests
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// PecosPulledPork should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }
        /// <summary>
        /// Changing the Bread Property should Invoke PropertyChanged for "Bread"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForbread()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "Bread", () =>
            {
                item.Bread = false;
            });
        }
        /// <summary>
        /// Changing the Bread Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bread = false;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = false;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Pickle = false;
            });
        }
    }
}
