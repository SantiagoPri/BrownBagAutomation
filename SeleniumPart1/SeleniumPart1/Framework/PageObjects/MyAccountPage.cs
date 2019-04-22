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
    class MyAccountPage
    {
        private IWebDriver driver;
        By liWomenOption = By.XPath("//*[@id=\"block_top_menu\"]/ul/li[1]");
        By lblSuccess = By.ClassName("info-account");

        public MyAccountPage (IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        /*[FindsBy(How = How.ClassName, Using = "info-account")]
        private IWebElement success;*/

        /*[FindsBy(How = How.XPath, Using = "//*[@id=\"block_top_menu\"]/ul/li[1]")]
        private IWebElement womenOption;*/


        public string GetSuccessMessage()
        {
            string success = Actions.GetText(driver, lblSuccess);
            return success;
            //return success.Text;
        }


        public void ClickOnWomenOption()
        {
            Actions.ClickOn(driver, liWomenOption);
        }

    }
}
