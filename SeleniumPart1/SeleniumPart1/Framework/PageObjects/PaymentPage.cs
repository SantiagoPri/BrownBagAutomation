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
        By btnPaybyCheck = By.ClassName("payment_module");

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        public void PaybyCheck()
        {
            Actions.ClickOn(driver, btnPaybyCheck);
        }
    }
}
