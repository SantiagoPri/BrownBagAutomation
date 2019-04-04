using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sele.PageObj;
using System;
using TechTalk.SpecFlow;

namespace Sele
{
    [Binding]
    public class WstepSteps
    {
        IWebDriver driver;
        Homepage home;
        Login log;
        Account act;
        Wishlist wish;
        Dresses dresses;
        Dress dress;


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            home = new Homepage(driver);
            log = new Login(driver);
            act = new Account(driver);
            wish = new Wishlist(driver);
            dresses = new Dresses(driver);
            dress = new Dress(driver);


        }

        [Given]
        public void GivenIEnterTheHomepage()
        {

            home.GoToPage();
            home.ClickOnAccount();
        }

        [Given]
        public void GivenILogIn()
        {
            log.login();
        }

        [Given]
        public void GivenClickOnWishlist()
        {
            act.FindWishlist();
            act.ClickOnWishlist();

        }

        [When]
        public void WhenICreateAWishlist()
        {
            wish.NewWishList("My sweet 16");

        }

        [When]
        public void WhenIGoToDressesSection()
        {
            wish.GoToDresses();

        }

        [When]
        public void WhenISelect_P0_OnADress(string p0)
        {
            dresses.FindMore();
            dresses.ClickOnMore();


        }

        [When]
        public void WhenIClickOn_P0(string p0)
        {
            dress.AddToWishlist();

        }

        [Then]
        public void ThenTheResultShouldBe_P0(string p0)
        {
            Assert.AreEqual("Added to your wishlist.", dress.Confirmation());
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
