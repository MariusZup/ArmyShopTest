using ArmyShopPages;
using ArmyShopTest.BaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopTest
{
    public class HomeBlogButton : BaseTest
    { 

        [SetUp]
        public static void setup()
        {
          HomeBlogButtonPage.open();
         
        }

        [Test]

        public static void Blogas()
        {
            string expectedMessage = "CARINTHIA - sukurta Jūsų saugumui ir komfortui";
            string acctualMessage;

            HomeBlogButtonPage.clickBlogas();
            acctualMessage = HomeBlogButtonPage.readMessage();

            Assert.AreEqual(expectedMessage, acctualMessage);
        }
    }
}
