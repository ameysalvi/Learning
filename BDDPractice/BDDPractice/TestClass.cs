using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using System.Drawing;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using BDDPractice.PageObjects;

namespace BDDPractice
{
    [Binding]
    public class TestClass
    {

        public IWebDriver driver;

        Objects obj = null;
        

        [BeforeScenario]
        public void StartBrowser()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--disable-extensions");
            
            options.AddArgument("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);
                

            driver = new ChromeDriver("D:\\LatestChromeDirver\\", options);
           
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";

            //Initialising all the objects
            obj = new Objects(driver);
            obj.ObjectInitialization();

        }

        [AfterScenario]
        //[TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
