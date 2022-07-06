using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages.Pages
{
    public class EmptyCartPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.Tests.Domain);
        }

        public static void closeAdvertisment()
        {
            string locator = "//*[@id='sbox-btn-close']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
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
        public static void clickCart()
        {
            string locator = "//*[@id='cartlink66']/div/div/div/a";
            Common.clickElement(locator);
        }
        public static void clickRemoveItem()
        {
            string locator = "//*[@id='delete_button_0']";
            Common.clickElement(locator);
        }

        public static string readRemovedText()
        {
            string locator = "//*[@id='system-message']/dd/ul/li/a";
            return Common.getElementText(locator);
        }
    }
}
