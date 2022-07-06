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
    public class EmptyCart : BaseTest
    {
        [SetUp]
        public static void setup()
        {
            EmptyCartPage.open();
            EmptyCartPage.closeAdvertisment();
        }

        [Test]

        public static void emptyCart()
        {
            string expectedMessage = "Jūsų prekių krepšelis yra tuščias! « Grįžti į prekių katalogą";
            string acctualMessage;

            EmptyCartPage.clickAirsoftButton();
            EmptyCartPage.clickPistolButton();
            EmptyCartPage.clickCo2Button();
            EmptyCartPage.addToCart();
            EmptyCartPage.clickCart();
            EmptyCartPage.clickRemoveItem();
            acctualMessage = AddToCartButtonPage.readCartMessage();

            Assert.IsTrue(acctualMessage.Contains(expectedMessage));
        }
    }
}
