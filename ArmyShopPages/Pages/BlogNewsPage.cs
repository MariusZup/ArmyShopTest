using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages.Pages
{
    public class BlogNewsPage
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
        public static void clickBlogas()
        {
            string locator = "//*[@id='position_menu1']/div/div/div/div/ul/li[5]/a";
            Common.clickElement(locator);
        }
        public static void clickRemoveBeforeFlight()
        {
            string locator = "//*[@id='content']/div[1]/div[2]/div/div[2]/div[2]/div[1]/div[1]/a";
            Common.clickElement(locator);
        }
        public static string readPageTitle()
        {
            string locator = "//*[@id='page_title']/h1/a";
            return Common.getElementText(locator);
        }
    }
}
