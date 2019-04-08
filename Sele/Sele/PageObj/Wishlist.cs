using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sele.PageObj
{
    class Wishlist
    {


        private IWebElement tag;
        private IWebDriver driver;





        public Wishlist(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void GoToDresses()
        {
            tag = Actions.buscarClassname(driver, "sf-with-ul");
            Actions.ClickOn(driver, tag);
        }


        public void NewWishList(string wishlistname)
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarIds(driver, "name");
            Actions.Type(driver, tag, wishlistname);
            tag = Actions.buscarIds(driver, "submitWishlist");
            Actions.ClickOn(driver, tag);


        }
    }
}
