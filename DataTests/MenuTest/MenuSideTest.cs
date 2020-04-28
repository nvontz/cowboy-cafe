using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuSideTest
    {
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void SidesShouldContainSides(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.SideList)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void SidesShouldHaveOnlyTwelveItems()
        {
            Assert.Equal(12, Menu.SideList.Count());
        }

        [Fact]
        public void MenuSideShouldContainExpectedStuff()
        {
            var sides = new List<IOrderItem>(Menu.SideList);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.SideList,
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); },
                (scd) => { Assert.IsType<CornDodgers>(scd); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); }
                );

        }
        
        
    }
}
