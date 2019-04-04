using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sele.PageObj
{
    class Dress
    {



        private IWebElement tag;
        private IWebDriver driver;





        public Dress(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void AddToWishlist()
        {
            tag = Actions.buscarIds(driver, "wishlist_button");
            Actions.ClickOn(driver, tag);
        }


        public string Confirmation()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarClassname(driver, "fancybox-error");
            return tag.Text;

         


        }
    }
}
