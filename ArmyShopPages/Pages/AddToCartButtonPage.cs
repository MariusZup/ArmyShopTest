using System;

namespace ArmyShopPages.Pages
{
    public class AddToCartButtonPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.Tests.Domain);
        }

        public static void clickAirsoftButton()
        {
            string locator = "//*[@id='catalog']/li[17]/a";
            Common.clickElement(locator);
        }

        public static void clickButton()
        {
            string locator = "//*[@id='vmMainPage']/div[2]/div/div/div/div/div/div/div[1]/div/div[2]/a";
            Common.clickElement(locator);
        }

        public static void clickButton2()
        {
            string locator = "//*[@id='vmMainPage']/div[2]/div/div/div/div/div/div/div[2]/div/div[2]/a";
            Common.clickElement(locator);
        }
        public static void addToCart()
        {
            string locator = "//*[@id='addtocart_browse_11683']/div[2]/div/input";
            Common.clickElement(locator);
        }

        public static string readCartMessage()
        {
            string locator = "//*[@id='system-message']/dd/ul/li";
            return Common.getElementText(locator);
        }
    }
}
