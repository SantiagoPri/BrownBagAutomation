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
    class ShippingPage
    {
        private IWebDriver driver;

        public ShippingPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }


        public void AgreeTermsOfService()
        {
            TestActions.ClickOnCheckBox(driver, By.Id("cgv"));
        }

        public void ClickOnProceedCheckout()
        {
            TestActions.ClickOnButton(driver, By.XPath("//*[@id=\"form\"]/p/button"));
        }
    }
}
