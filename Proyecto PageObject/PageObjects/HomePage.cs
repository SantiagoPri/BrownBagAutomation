using ProjectPageObject.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPageObject.PageObjects
{
    class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement contactLink;

        [FindsBy(How = How.ClassName, Using = "header_user_info")]
        private IWebElement signIn;


        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            PageFactory.InitElements(driver, this);
        }

       

        public void ClickOnContactLink()
        {
            TestActions.ClickOn(driver, contactLink);
        }


        public void ClickOnSignIn()
        {
            TestActions.ClickOn(driver, signIn);
        }


    }
}
