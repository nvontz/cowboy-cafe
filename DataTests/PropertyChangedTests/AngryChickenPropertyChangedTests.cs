using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// Angry Chicken should Implement the INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void AngryChikenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        /// <summary>
        /// Changing the Bread Property should Invoke PropertyChanged for "Bread"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }
        /// <summary>
        /// Changing the Bread Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstuctions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }
        /// <summary>
        /// Changing the Pickle Property should Invoke PropertyChanged for "Special Instructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}
