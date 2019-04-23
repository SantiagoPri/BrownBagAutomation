using ProjectPageObject.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPageObject.PageObjects
{
    class ContactUsPage
    {

        private IWebDriver driver;


        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "id_contact")]
        private IWebElement selectSubject;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddressField;

        [FindsBy(How = How.Id, Using = "id_order")]
        private IWebElement orderReferenceField;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement messageField;

        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement sendButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p")]
        private IWebElement msgSuccess;




        public void Fillform(string email, string orderReference, string msg)
        {
            TestActions.SelectDropdown(this.driver, selectSubject, "2");
            TestActions.TypeField(this.driver, emailAddressField, email);
            TestActions.TypeField(this.driver, orderReferenceField, orderReference);
            TestActions.TypeField(this.driver, messageField, msg);
            TestActions.ClickOn(this.driver, sendButton);
        }

        public string GetSuccessMsg()
        {
            return msgSuccess.Text;
        }
    }
}
