using OpenQA.Selenium;
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

        public static void clickAirsoftButton()
        {
            string locator = "//*[@id='catalog']/li[17]/a";
            Common.clickElement(locator);
        }

        public static void clickPistolButton()
        {
            string locator = "//*[@id='vmMainPage']/div[2]/div/div/div/div/div/div/div[1]/div/div[2]/a";
            Common.clickElement(locator);
        }

        public static void clickCo2Button()
        {
            string locator = "//*[@id='vmMainPage']/div[2]/div/div/div/div/div/div/div[2]/div/div[2]/a";
            Common.clickElement(locator);
        }
        public static void clickFullMetal()
        {
            string locator = "//*[@id='vmMainPage']/div[3]/div[4]/div[1]/div[1]/div/div/div[2]/div[1]/a";
            Common.clickElement(locator);
        }
        public static void addToCart()
        {
            string locator = "//*[@id='addtocart_62c58961ae111']";
            Common.clickElement(locator);
        }
        public static void clickCart()
        {
            string locator = "//*[@id='module91']/div/div/div/div/div/div[2]/div/div";
            Common.clickElement(locator);
        }
        public static void clickRemoveItem()
        {
            string locator = "//*[@id='mega_cart_product_form_0']/div[2]/div[3]";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
        }

        public static string readRemovedText()
        {
            string locator = "//*[@id='system-message']/dd/ul/li/a";
            return Common.getElementText(locator);
        }
    }
}
