using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //IWebDriver driver;

        static void Main(string[] args)
        {              

        }

        [SetUp]
        public void Initalize()
        {
            //this your chromedriver path
            string driverPath = "D:\\LatestChromeDirver\\";

            //piece of code to diable that popup
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);

            //opening chrome driver
            PropertiesCollection.driver = new ChromeDriver(driverPath, options);

            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            
        }

        [Test]

        public void ExecuteTest()
        {
            ExcelUtility excelUtility = new ExcelUtility();
            excelUtility.ExcelToDataTable(@"‪C:\JavaAutomation\POM\Book1.xls");

            TestHomePO TestHomePage = new TestHomePO();
            //BasicFirstFormDemoPO BasicFirstFormDemoPage = new BasicFirstFormDemoPO();

            TestHomePage.adHandle();
            TestHomePage.ClickMenu();
            BasicFirstFormDemoPO BasicFirstFormDemoPage = TestHomePage.ClickSubMenu();

            string enteredValue = BasicFirstFormDemoPage.EnterShowMessage("Testing");
            BasicFirstFormDemoPage.VerifyMessage(enteredValue);


            //SeleniumSetMethods.Click("//a[@class='dropdown-toggle'][contains(text(),'Input Forms')]", PropertyType.XPath);
            //SeleniumSetMethods.Click(, PropertyType.XPath);
            //SeleniumSetMethods.EnterText("user-message", "Testing", PropertyType.Id);
            //SeleniumSetMethods.Click("//button[contains(text(),'Show Message')]", PropertyType.XPath);
            //Console.WriteLine(SeleniumGetMethods.GetText("//label[contains(text(),'Your Message:')]", PropertyType.XPath) + " - " + SeleniumGetMethods.GetText("display", PropertyType.Id));
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
