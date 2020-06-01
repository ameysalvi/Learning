using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class BasicFirstFormDemoPO
    {

                
        public BasicFirstFormDemoPO()
        {
            //PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-message")]
        public IWebElement txtEnterMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Show Message')]")]
        public IWebElement btnShowMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Your Message:')]")]
        public IWebElement lblYourMessage { get; set; }

        [FindsBy(How = How.Id, Using = "display")]
        public IWebElement lblDisplay { get; set; }

        
        public string EnterShowMessage(string value)
        {
            txtEnterMessage.EnterText(value);
            btnShowMessage.Clicks();
            //SeleniumSetMethods.EnterText(txtEnterMessage, value);
            //SeleniumSetMethods.Click(btnShowMessage);
            return value;
        }

        public void VerifyMessage(string enteredValue)
        {
            string displayValue = lblDisplay.GetText();
            Assert.AreEqual(displayValue, enteredValue);
            Console.WriteLine(lblYourMessage.GetText() + "- " + displayValue);
        }

    }
}
