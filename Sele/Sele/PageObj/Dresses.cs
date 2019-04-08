using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sele.PageObj
{
    class Dresses
    {




        private IWebElement tag;
        private IWebDriver driver;





        public Dresses(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void ClickOnMore()
        {
            Actions.ClickOn(driver, tag);
        }


        public void FindMore()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            tag = Actions.buscarXpath(driver, "//*[@id=\"center_column\"]/ul/li[1]/div/div[2]/div[2]/a[2]");
        }
    }
}
