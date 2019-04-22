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
    class HomePage
    {
        private IWebDriver driver;
        By divSignIn = By.ClassName("header_user_info");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //PageFactory.InitElements(driver, this);
        }

        
        /*[FindsBy(How = How.ClassName, Using = "header_user_info")]
        private IWebElement signIn;*/


        
        public void ClickOnSignIn()
        {
            Actions.ClickOn(driver, divSignIn);
        }
    }
}
