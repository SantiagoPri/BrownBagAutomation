using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPart1.Framework.PageObjects;

namespace SeleniumPart1
{
    [TestClass]
    public class AddToCart
    {
        IWebDriver driver;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TestMethod]
        public void TestMethod1()
        {
            HomePage homePage = new HomePage(driver);
            LogInPage logInPage = new LogInPage(driver);
            MyAccountPage myAccountPage = new MyAccountPage(driver);
            CatalogPage catalogPage = new CatalogPage(driver);
            Window window = new Window(driver);
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(driver);
            AdressPage adressPage = new AdressPage(driver);
            ShippingPage shippingPage = new ShippingPage(driver);
            PaymentPage paymentPage = new PaymentPage(driver);
            OrderSummaryPage orderSummaryPage = new OrderSummaryPage(driver);
            OrderConfirmationPage orderConfirmationPage = new OrderConfirmationPage(driver);

            homePage.GoToPage();
            homePage.ClickOnSignIn();
            logInPage.FillLogInForm("ggggg8881@gmail.com", "clave1");
            logInPage.ClickOnSubmitLogin();
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", myAccountPage.GetSuccessMessage());
            myAccountPage.ClickOnWomenOption();
            catalogPage.ClickOnAddtoCartButton();
            window.ClickOnProceedCheckout();
            shoppingCartPage.ClickOnProceedCheckout();
            adressPage.ClickOnProceedCheckout();
            shippingPage.AgreeTermsOfService();
            shippingPage.ClickOnProceedCheckout();
            paymentPage.PaybyCheck();
            orderSummaryPage.ClickOnProceedCheckout();
            orderConfirmationPage.GetSuccessMessage();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
