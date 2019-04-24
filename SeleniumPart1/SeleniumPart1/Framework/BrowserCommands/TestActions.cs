using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPart1.Framework.BrowserCommands
{
    class TestActions
    {
        public static void ClickOnButton(IWebDriver driver, By by)
        {
            WaitForElementClickable(driver, by);
            IWebElement element = driver.FindElement(by);
            element.Click();

            /*IWebElement element;

            try
            {
                WaitForElementVisible(driver, by);
                element = driver.FindElement(by);
            }
            catch
            {
                element = null;
            }

            if (element != null)
            {
                try
                {
                    element.Click();
                }
                catch
                {
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                    executor.ExecuteScript("arguments[0].click();", by);
                }
            }*/
        }

        public static void ClickOnCheckBox(IWebDriver driver, By by)
        {
            WaitForElementExist(driver, by);
            IWebElement element = driver.FindElement(by);

            if (!element.Selected)
            {
                element.Click();
            }
        }


        public static void WaitForElementClickable(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }



        public static void WaitForElementVisible(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static void WaitForElementExist(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(by));
        }





        public static void Type(IWebDriver driver, By by, string value)
        {
            WaitForElementVisible(driver, by);
            IWebElement element = driver.FindElement(by);
            element.SendKeys(value);
        }


        public static void SelectValue(IWebDriver driver, By by, string value)
        {
            WaitForElementVisible(driver, by);
            IWebElement element = driver.FindElement(by);
            SelectElement subjectHeading = new SelectElement(element);
            subjectHeading.SelectByValue(value);
        }

        public static string GetText(IWebDriver driver, By by)
        {
            WaitForElementVisible(driver, by);
            IWebElement element = driver.FindElement(by);
            return element.Text;
        }

    }


}
