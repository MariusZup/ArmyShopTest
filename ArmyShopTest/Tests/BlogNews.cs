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
    public class BlogNews : BaseTest
    {
        [SetUp]
        public static void setup()
        {
            BlogNewsPage.open();

        }

        [Test]

        public static void removeBeforeFlight()
        {
            string expectedMessage = "Remove before flight – raudonos juostelės svarba";
            string acctualMessage;

            BlogNewsPage.clickBlogas();
            BlogNewsPage.clickRemoveBeforeFlight();
            acctualMessage = BlogNewsPage.readPageTitle();

            Assert.AreEqual(expectedMessage, acctualMessage);
        }
    }
}
