using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sele.PageObj
{
    class Login
    {



        private IWebElement tag;
        private IWebDriver driver;





        public Login(IWebDriver driver)
        {
            this.driver = driver;

        }




        public void login()
        {
            tag = Actions.buscarIds(driver, "email");
            Actions.Type(driver, tag, "belatest@test.com");
            tag = Actions.buscarIds(driver, "passwd");
            Actions.Type(driver, tag, "avadakedabra");
            tag = Actions.buscarIds(driver, "SubmitLogin");
            Actions.ClickOn(driver, tag);

        }


        
    }
}
