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
    class PaymentPage
    {
        private IWebDriver driver;

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        public void PaybyCheck()
        {
            TestActions.ClickOnButton(driver, By.ClassName("payment_module"));
        }
    }
}
