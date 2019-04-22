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
        By txtEmail = By.Id("email");
        By txtPassword = By.Id("passwd");
        By btnSubmit = By.Id("SubmitLogin");

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
            Actions.Type(driver, txtEmail, email);
            Actions.Type(driver, txtPassword, pass);
        }

        public void ClickOnSubmitLogin()
        {
            Actions.ClickOn(driver, btnSubmit);
        }
    }
}
