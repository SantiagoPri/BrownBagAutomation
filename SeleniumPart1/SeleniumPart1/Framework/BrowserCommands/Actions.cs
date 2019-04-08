using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPart1.Framework.BrowserCommands
{
    class Actions
    {
        public static void ClickOn(IWebDriver driver, By by)
        {
            IWebElement element;

            try
            {
                WaitForElement(driver, by);
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
            }
        }

        public static void ClickOnTest(IWebDriver driver, IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);

            }
        }

        
        public static void WaitForElement(IWebDriver driver, By by)
        {
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

       
        public static void Type(IWebDriver driver, By by, string value)
        {            
            WaitForElement(driver, by);
            IWebElement element = driver.FindElement(by);
            element.SendKeys(value);
        }


        public static void SelectValue(IWebDriver driver, By by, string value)
        {
            WaitForElement(driver, by);
            IWebElement element = driver.FindElement(by);
            SelectElement subjectHeading = new SelectElement(element);
            subjectHeading.SelectByValue(value);
        }

    }
}
