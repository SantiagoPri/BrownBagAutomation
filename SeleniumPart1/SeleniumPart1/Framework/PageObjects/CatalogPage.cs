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
    class CatalogPage
    {
        private IWebDriver driver;

        public CatalogPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /*[FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/ul/li[1]/div/div[2]/div[2]/a[1]")]
        private IWebElement addcartButton;*/

        
        

        public void ClickOnAddtoCartButton()
        {
            Actions.ClickOn(driver, By.XPath("//*[@id=\"center_column\"]/ul/li[1]/div/div[2]/div[2]/a[1]"));
        }
                

       
    }
}
