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
    class LogInPage
    {
        private IWebDriver driver;

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        
        /*[FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailLogIn;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement btnSignIn;*/


        
        public void FillLogInForm(string email, string pass)
        {
            TestActions.Type(driver, By.Id("email"), email);
            TestActions.Type(driver, By.Id("passwd"), pass);
        }

        public void ClickOnSubmitLogin()
        {
            TestActions.ClickOnButton(driver, By.Id("SubmitLogin"));
        }
    }
}
