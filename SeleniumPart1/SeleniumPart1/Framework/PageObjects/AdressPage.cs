﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPart1.Framework.BrowserCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPart1.Framework.PageObjects
{
    class AdressPage
    {        
        private IWebDriver driver;
        By btnProceedCheckout = By.XPath("//*[@id=\"center_column\"]/form/p/button");

        public AdressPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        public void ClickOnProceedCheckout()
        {
            Actions.ClickOn(driver, btnProceedCheckout);
        }

    }
}
