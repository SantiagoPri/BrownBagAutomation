using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sele.PageObj
{
    class Account
    {



        private IWebElement tag;
        private IWebDriver driver;





        public Account(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void ClickOnWishlist()
        {
            Actions.ClickOn(driver, tag);
        }


        public void FindWishlist()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarClassname(driver, "lnk_wishlist");
        }
    }
}
