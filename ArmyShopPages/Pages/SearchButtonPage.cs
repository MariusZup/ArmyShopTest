using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages.Pages
{
    public class SearchButtonPage
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

        public static void TypeInSearchField(string expectedSearch)
        {
            string locator = "//*[@id='form']/form/div/input";
            Common.sendKeysToElement(locator, expectedSearch);
        }

        public static void clickSearchButton()
        {
            string locator = "//*[@id='form']/form/div/div[1]/input";
            Common.clickElement(locator);
        }
        public static string readMessage()
        {
            string locator = "//*[@id='page_title']/h1";
            return Common.getElementText(locator);
        }
    }
}
