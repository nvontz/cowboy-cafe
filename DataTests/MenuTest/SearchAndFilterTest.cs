using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.MenuTest
{
    public class SearchAndFilterTest
    {
        [Fact]
        public void SearchingAValueWorks()
        {
            var items = Menu.CompleteList;
            items = Menu.Search("Cow");
            Assert.Collection(
               items,
               (cc) => { Assert.IsType<CowpokeChili>(cc); },
               (scc) => { Assert.IsType<CowboyCoffee>(scc); },
               (mcc) => { Assert.IsType<CowboyCoffee>(mcc); },
               (lcc) => { Assert.IsType<CowboyCoffee>(lcc); }
               );
        }
        [Fact]
        public void SearchingANullValueWorks()
        {
            var items = Menu.CompleteList;
            items = Menu.Search(null);
            Assert.Collection(
               items,
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
        [Fact]
        public void NullCategoriesReturnCategories()
        {
            var items = Menu.CompleteList;
            items = Menu.FilterByCategory(items, Menu.Categories);
            Assert.Collection(
               items,
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
        [Fact]
        public void CaloriesReturnCalorieItems()
        {
            var items = Menu.CompleteList;
            items = Menu.FilterByCalories(items, null, 2);
            Assert.Collection(
               items,
                (sw) => { Assert.IsType<Water>(sw); },
                (mw) => { Assert.IsType<Water>(mw); },
                (lw) => { Assert.IsType<Water>(lw); }
               );
        }

        [Fact]
        public void PriceReturnsPriceItems()
        {
            var items = Menu.CompleteList;
            items = Menu.FilterByPrice(items, null, 1);
            Assert.Collection(
               items,
                (stt) => { Assert.IsType<TexasTea>(stt); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); },
                (sw) => { Assert.IsType<Water>(sw); },
                (mw) => { Assert.IsType<Water>(mw); },
                (lw) => { Assert.IsType<Water>(lw); }
               );
        }

    }
}
