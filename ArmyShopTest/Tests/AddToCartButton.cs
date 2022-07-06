using ArmyShopPages.Pages;
using ArmyShopTest.BaseClasses;
using NUnit.Framework;

namespace ArmyShopTest.Tests
{
    public class AddToCartButton : BaseTest
    {

        [SetUp]
        public static void setup()
        {
            AddToCartButtonPage.open();
            AddToCartButtonPage.closeAdvertisment();
        }

        [Test]

        public static void addToCart()
        {
            string expectedMessage = "Prekė buvo įtraukta į krepšelį.";
            string acctualMessage;

            AddToCartButtonPage.clickAirsoftButton();
            AddToCartButtonPage.clickButton();
            AddToCartButtonPage.clickButton2();
            AddToCartButtonPage.addToCart();
            acctualMessage = AddToCartButtonPage.readCartMessage();

            Assert.IsTrue(acctualMessage.Contains(expectedMessage));
        }
    }
}
