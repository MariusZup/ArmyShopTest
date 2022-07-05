using ArmyShopPages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace ArmyShopTest.BaseClasses
{
     public class BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            Driver.setDriver();
        }

        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
            }

            Driver.closeDriver();
        }
    }
}
