using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjectPageObject.PageObjects;

namespace ProjectPageObject
{
    [TestClass]
    public class CreateAccountTest
    {
        IWebDriver driver;

        [TestInitialize] //Configuración inicial del test
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TestMethod]
        public void Register()
        {
            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = new SignInPage(driver);
            CreateAccountPage createAccountPage = new CreateAccountPage(driver);
            MyAccountPage myAccountPage = new MyAccountPage(driver);


            homePage.GoToPage();
            homePage.ClickOnSignIn();

            int i = new Random().Next(0, 150);
            signInPage.CreateAccount("FakeEmail" + i + "@fake.com");
            
            
            createAccountPage.FillPersonalInfo("Patricia", "Londoño", "clave1");
            createAccountPage.FillDropdowns("4","4", "1995");
            createAccountPage.FillAddress("AFakeCompany", "Street fake", "123", "New Fake", "32", "10013", "21", "12345678", "MyFakeAlias");

            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", myAccountPage.GetLogInMsg());
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
