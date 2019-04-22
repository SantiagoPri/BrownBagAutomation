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
        By chkTermsofService = By.Id("cgv");
        By btnProceedCheckout = By.XPath("//*[@id=\"form\"]/p/button");

        public ShippingPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }


        public void AgreeTermsOfService()
        {
            Actions.ClickOn(driver, chkTermsofService);
        }

        public void ClickOnProceedCheckout()
        {
            Actions.ClickOn(driver, btnProceedCheckout);
        }
    }
}
