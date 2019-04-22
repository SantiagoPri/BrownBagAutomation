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
    class OrderConfirmationPage
    {
        private IWebDriver driver;
        By lblSuccess = By.XPath("//*[@id=\"center_column\"]/p[1]");

        public OrderConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        /*[FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p[1]")]
        private IWebElement success;*/


        public string GetSuccessMessage()
        {
            string success = Actions.GetText(driver, lblSuccess);
            return success;
        }

    }
}
