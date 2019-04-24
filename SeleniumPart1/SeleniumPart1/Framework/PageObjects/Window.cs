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
    class Window
    {
        private IWebDriver driver;

        public Window(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        

        /*[FindsBy(How = How.XPath, Using = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")]
        private IWebElement proceedButton;*/



        public void ClickOnProceedCheckout()
        {
            TestActions.ClickOnButton(driver, By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a"));
        }

    }
}
