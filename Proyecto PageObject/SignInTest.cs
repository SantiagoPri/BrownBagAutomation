using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using ProjectPageObject.PageObjects;

namespace ProjectPageObject
{
    [TestClass]
    public class SignInTest
    {
        IWebDriver driver;
        
        [TestInitialize] //Configuración inicial del test
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TestMethod] //Donde hacemos el paso a paso que está indicado en el testcase
        public void SignIn()
        {

            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = new SignInPage(driver);
            MyAccountPage myAccountPage = new MyAccountPage(driver);

            
            homePage.GoToPage();
            homePage.ClickOnSignIn();
            
            signInPage.FillSignIn("anEmail3@fake.com", "Password");
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", myAccountPage.GetLogInMsg());
        }

        [TestCleanup] //Cierra el driver
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
