using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyShopPages
{
    public class Constants
    {
        public class Urls
        {
            public class Tests
            {
                public static string Domain = "https://www.army-shop.lt/";
                public static string LoginButtonPage = $"{Domain}/index.php?option=com_virtuemart&view=page&page=checkout.login_form&Itemid=30&lang=lt";
                public static string SearchButtonPage = $"{Domain}lt/shop/browse/search/";

            }
        }
    }
}
