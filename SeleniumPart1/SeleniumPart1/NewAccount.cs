using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPart1
{
    [TestClass]
    public class NewAccount
    {
        IWebDriver driver;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
        }

        [TestMethod] // Donde hacemos el paso a paso que está indicado en el testcase
        public void CreateAccount()
        {
            driver.Url = "http://automationpractice.com/index.php?";
            driver.FindElement(By.ClassName("header_user_info")).Click();
            driver.FindElement(By.Id("email_create")).SendKeys("sssss8887@gmail.com");
            driver.FindElement(By.Id("SubmitCreate")).Click();

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            IWebElement gender = wait.Until(driver => driver.FindElement(By.Id("id_gender2")));
            gender.Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("Patricia");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Londoño");
            driver.FindElement(By.Id("passwd")).SendKeys("clave1");

            SelectElement dayBirth = new SelectElement(driver.FindElement(By.Id("days")));
            dayBirth.SelectByValue("19");
            SelectElement monthBirth = new SelectElement(driver.FindElement(By.Id("months")));
            monthBirth.SelectByValue("6");
            SelectElement yearBirth = new SelectElement(driver.FindElement(By.Id("years")));
            yearBirth.SelectByValue("1984");

            driver.FindElement(By.Id("address1")).SendKeys("163 Rockland Street Port Orange, FL 32127");
            driver.FindElement(By.Id("city")).SendKeys("Philadelphia");

            SelectElement state = new SelectElement(driver.FindElement(By.Id("id_state")));
            state.SelectByValue("38");

            driver.FindElement(By.Id("postcode")).SendKeys("77777");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("202-555-0153");
            driver.FindElement(By.Id("submitAccount")).Click();

            string success = driver.FindElement(By.ClassName("info-account")).Text;
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", success);
        }



        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
