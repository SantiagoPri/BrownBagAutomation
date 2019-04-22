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
    class ShoppingCartPage
    {
        private IWebDriver driver;
        By btnProceedCheckout = By.XPath("//*[@id=\"center_column\"]/p[2]/a[1]");

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }


        /*[FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p[2]/a[1]")]
        private IWebElement proceedCheckoutButton;*/
        

        public void ClickOnProceedCheckout()
        {
            Actions.ClickOn(driver, btnProceedCheckout);
        }


    }
}
