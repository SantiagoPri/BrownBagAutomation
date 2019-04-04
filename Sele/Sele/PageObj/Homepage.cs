using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sele.PageObj
{
    class Homepage
    {


        private IWebElement tag;
        private IWebDriver driver;





        public Homepage(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void ClickOnAccount()
        {
            Actions.ClickOn(driver, tag);
        }


        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarClassname(driver, "login");
        }
    }
}
