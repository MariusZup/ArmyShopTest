using ArmyShopPages.Pages;
using NUnit.Framework;

namespace ArmyShopTest.Tests
{
    public class AddToCartButton
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
            acctualMessage = AddToCartButtonPage.readMessage();

            Assert.IsTrue(acctualMessage.Contains(expectedMessage));
        }
    }
}
