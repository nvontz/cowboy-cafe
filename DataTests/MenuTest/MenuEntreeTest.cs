using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuEntreeTest
    {

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void EntreeListShouldContainEntrees(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.EntreeList)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void EntreeShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.EntreeList.Count());
        }

        [Fact]
        public void MenuEntreeShouldContainExpectedStuff()
        {
            var entree = new List<IOrderItem>(Menu.EntreeList);
            entree.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.EntreeList,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); }
                );

        }
    }
}
