using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning
{
    class AlertPopup
    {
        IWebDriver driver;
        string baseUrl = "https://the-internet.herokuapp.com/javascript_alerts ";        

        [SetUp]

        public void openBrowser()
        {
            //this your chromedriver path
            string driverPath = "D:\\LatestChromeDirver\\";

            //piece of code to diable that popup
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);

            //opening chrome driver
            driver = new ChromeDriver(driverPath, options);

            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void AlertPopupTest()
        {

            IWebElement result = driver.FindElement(By.Id("result"));
            string strResult = "";

            //Alert Button
            IWebElement jsAlertBtn = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            jsAlertBtn.Click();
            driver.SwitchTo().Alert().Accept();
            
            strResult = result.Text;
            //Assert.True(strResult == "You successfuly clicked an alert", strResult);
            Assert.AreEqual("You successfuly clicked an alert", strResult);
            if (strResult == "You successfuly clicked an alert")
            {
                Console.WriteLine("Test Passed");
            }

            //Confirm Button
            IWebElement jsConfirmBtn = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]"));

            jsConfirmBtn.Click();
            driver.SwitchTo().Alert().Accept();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You clicked: Ok", strResult);
            if (strResult == "You clicked: Ok")
            {
                Console.WriteLine("Test Passed");
            }
            
            jsConfirmBtn.Click();            
            driver.SwitchTo().Alert().Dismiss();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You clicked: Cancel", strResult);
            if (strResult == "You clicked: Cancel")
            {
                Console.WriteLine("Test Passed");
            }

            //Prompt Button
            IWebElement jsPromptBtn = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));

            jsPromptBtn.Click();
            driver.SwitchTo().Alert().Accept();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You entered:", strResult);
            if (strResult == "You entered:")
            {
                Console.WriteLine("Test Passed");
            }                      

            jsPromptBtn.Click();
            driver.SwitchTo().Alert().Dismiss();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You entered: null", strResult);
            if (strResult == "You entered: null:")
            {
                Console.WriteLine("Test Passed");
            }

            jsPromptBtn.Click();
            driver.SwitchTo().Alert().SendKeys("TestingAccept");
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Accept();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You entered: TestingAccept", strResult);
            if (strResult == "You entered: TestingAccept")
            {
                Console.WriteLine("Test Passed");
            }
            
            jsPromptBtn.Click();
            driver.SwitchTo().Alert().SendKeys("TestingDismiss");
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Dismiss();
            strResult = "";
            strResult = result.Text;
            Assert.AreEqual("You entered: null", strResult);
            if (strResult == "You entered: null")
            {
                Console.WriteLine("Test Passed");
            }

        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
