using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.MenuTest
{
    public class MenuDrinkTest
    {

        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void DrinkShouldContainDrink(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.DrinkList)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void DrinkShouldHaveOnlyTwelveItems()
        {
            Assert.Equal(12, Menu.DrinkList.Count());
        }

        [Fact]
        public void MenuDrinkShouldContainExpectedStuff()
        {
            var drink = new List<IOrderItem>(Menu.DrinkList);
            drink.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.DrinkList,
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); },
                (stt) => { Assert.IsType<TexasTea>(stt); },
                (mtt) => { Assert.IsType<TexasTea>(mtt); },
                (ltt) => { Assert.IsType<TexasTea>(ltt); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); },
                (sw) => { Assert.IsType<Water>(sw); },
                (mw) => { Assert.IsType<Water>(mw); },
                (lw) => { Assert.IsType<Water>(lw); }

                );

        }
    }
}
