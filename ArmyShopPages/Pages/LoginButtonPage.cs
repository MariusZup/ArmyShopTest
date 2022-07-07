using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages.Pages
{
    public class LoginButtonPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.Tests.Domain);
        }

        public static void clickLogin()
        {
            string locator = "//*[@id='position_menu1']/div/div/div/div/ul/li[3]/a";
            Common.clickElement(locator);
        }

        public static void clickForgotPassword()
        {
            string locator = "//*[@id='vmMainPage']/div/form/div[2]/div[2]/a";
            Common.clickElement(locator);
        }

        public static void typeEmail(string email)
        {
            string locator = "//*[@id='email']";
            Common.sendKeysToElement(locator, email);
        }

        public static void clickSubmit()
        {
            string locator = "//*[@id='content']/div/form/div[4]/div/button";
            Common.clickElement(locator);
        }
        public static string getNameAfterSubmit()
        {
            string locator = "//*[@id='system-message']/dd/ul/li";
             return Common.getElementText(locator);
        }
    }
}
