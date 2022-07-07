using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages
{
    public class HomeBlogButtonPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.Tests.Domain);
        }
        public static void clickBlogas()
        {
            string locator = "//*[@id='position_menu1']/div/div/div/div/ul/li[5]/a";
            Common.clickElement(locator);
        }
        public static string readMessage()
        {
            string locator = "//*[@id='content']/div[1]/div[1]/div/div[1]/div[1]/a";
            return Common.getElementText(locator);
        }
    }
}
