using OpenMRS.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenMRS
{

    [Binding]
    public class TestFixtures
    {        
        public IWebDriver driver;

        AllPageObjects obj = null;

        [BeforeScenario]
        public void BeforeScenario()
        {
            OpenChromeBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }

        public void OpenChromeBrowser()
        {
            //this your chromedriver path
            string driverPath = "D:\\LatestChromeDirver\\";

            //piece of code to diable that popup
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);

            //opening chrome driver
            driver = new ChromeDriver(driverPath, options);

            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("Url"));
            driver.Manage().Window.Maximize();

            obj = new AllPageObjects(driver);
            obj.ObjectInitialization();
        }
    }
}
