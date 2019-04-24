using System;
using ProjectPageObject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ProjectPageObject
{
    [TestClass]
    public class ContactUs
    {
        IWebDriver driver;


        [TestInitialize] //Configuración inicial del test
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TestMethod] //Donde hacemos el paso a paso que está indicado en el testcase
        public void ContactUsTest()
        {

            HomePage homePage = new HomePage(driver);
            ContactUsPage contactUsPage = new ContactUsPage(driver);

            homePage.GoToPage();
            homePage.ClickOnContactLink();

            contactUsPage.Fillform("hola@mailinator.com", "1012252", "this is a test for automation");
            Assert.AreEqual("Your message has been successfully sent to our team.", contactUsPage.GetSuccessMsg());
        }

        [TestCleanup] //Cierra el driver
        public void TestCleanup()
        {
           driver.Quit();
        }
    }
}
