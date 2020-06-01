using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class GoogleTest
    {

        IWebDriver driver;

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

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void googleTest()
        {
            IWebElement searchText = driver.FindElement(By.ClassName("gLFyf"));
            searchText.SendKeys("Rave Technologies");
            searchText.SendKeys(Keys.Enter);

            //IWebElement linkClick = driver.FindElement(By.XPath("//*[@id='rso']/div[4]/div/div[1]/a/h3"));
            //linkClick.Click();

            List<IWebElement> links = new List<IWebElement>(driver.FindElements(By.ClassName("LC20lb")));
            links[4].Click();

            //IWebElement firstLink = links.First<IWebElement>();
            //firstLink.Click();
            
            //int linkCount = links.Count();
            //if (linkCount == 1)
            //{
            //    IWebElement clickLink = links.ElementAt(linkCount);                
            //    clickLink.Click();
            //}
            //else
            //{
            //    Console.WriteLine("No link found");
            //}

            //for (int i = 1; i < linkCount; i++)
            //{
            //    IWebElement clickLink = links.ElementAt(i);
            //    clickLink.Click();
            //    Console.WriteLine(clickLink);
            //}
        }           


        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }
                
    }
}
