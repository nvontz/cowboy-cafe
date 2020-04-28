using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.MenuTest
{
    public class CompleteTest
    {
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void MenuShouldContainItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteList)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void MenuShouldHaveOnly31Items()
        {
            Assert.Equal(31, Menu.CompleteList.Count());
        }

        [Fact]
        public void MenuShouldContainExpectedStuff()
        {
            var menu = new List<IOrderItem>(Menu.CompleteList);
            menu.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                Menu.CompleteList,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
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
                (lbb) => { Assert.IsType<BakedBeans>(lbb); },
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
