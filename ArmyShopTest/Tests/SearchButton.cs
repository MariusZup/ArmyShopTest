using ArmyShopPages;
using ArmyShopPages.Pages;
using ArmyShopTest.BaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopTest.Tests
{
    public class SearchButton : BaseTest
    {
        [SetUp]
        public static void setup()
        {
            SearchButtonPage.open();
         
        }

        [Test]

        public static void search()
        {
            string expectedSearch = "Kuprinė";
            string acctualSearchResult;

            SearchButtonPage.TypeInSearchField(expectedSearch);
            SearchButtonPage.clickSearchButton();
            acctualSearchResult = SearchButtonPage.readMessage();

            Assert.IsTrue(acctualSearchResult.Contains(expectedSearch));
        }
    }
}
