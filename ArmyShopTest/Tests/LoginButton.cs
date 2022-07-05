using ArmyShopPages;
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
    public class LoginButton : BaseTest
    {

        [SetUp]
        public static void setup()
        {
            LoginButtonPage.open();
            LoginButtonPage.closeAdvertisment();
        }

        [Test]

        public static void Login()
        {
            string expectedMessage = "Jūsų slaptažodžio pakeisti nepavyko, nes Vartotojas su tokiu el.pašto adresu ir prisijungimo vardu nerastas.";
            string expectedEmail = "testas@gmail.com";
            string acctualMessage;

            LoginButtonPage.clickLogin();
            LoginButtonPage.clickForgotPassword();
            LoginButtonPage.typeEmail(expectedEmail);
            LoginButtonPage.clickSubmit();
            LoginButtonPage.getNameAfterSubmit();
            string actualName = LoginButtonPage.getNameAfterSubmit();

            Assert.IsTrue(actualName.Contains(expectedMessage));

        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
