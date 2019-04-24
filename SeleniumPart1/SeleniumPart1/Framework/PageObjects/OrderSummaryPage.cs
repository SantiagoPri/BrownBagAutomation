using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPart1.Framework.BrowserCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPart1.Framework.PageObjects
{
    class OrderSummaryPage
    {
        private IWebDriver driver;

        public OrderSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        public void ClickOnProceedCheckout()
        {
            TestActions.ClickOnButton(driver, By.XPath("//*[@id=\"cart_navigation\"]/button"));
        }
    }
}
