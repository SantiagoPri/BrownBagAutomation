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

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //PageFactory.InitElements(driver, this);
        }

        /*[FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement contactLink;

        [FindsBy(How = How.ClassName, Using = "header_user_info")]
        private IWebElement signIn;*/


           
        
        public void ClickOnContackLink()
        {
            TestActions.ClickOnButton(driver, By.Id("contact-link"));
        }


        public void ClickOnSignIn()
        {
            TestActions.ClickOnButton(driver, By.ClassName("header_user_info"));
        }
    }
}
