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
    class DemoAtata
    {
        IWebDriver driver;
        string signInUrl = "https://demo.atata.io/signin";
        string userUrl = "https://demo.atata.io/users";
        string username = "admin@mail.com";
        string pass = "abc123";

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

            driver.Navigate().GoToUrl(signInUrl);
            //driver.Manage().Window.Maximize();
        }

        [Test]

        public void demoAtataTest()
        {
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys(username);

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys(pass);

            IWebElement signIn = driver.FindElement(By.ClassName("btn"));
            signIn.Click();

            string expectedUrl = driver.Url;
            Console.WriteLine(expectedUrl);

            Assert.AreEqual(userUrl, expectedUrl);

            IWebElement elemTable = driver.FindElement(By.ClassName("table"));
            IList<IWebElement> lstTrElem = elemTable.FindElements(By.TagName("tr"));
            //lstTrElem.RemoveAt(0);
            foreach (IWebElement elemTr in lstTrElem)
            {
                string actualColName = elemTr.FindElements(By.TagName("td"))[2].Text;
                if(actualColName == username)
                {
                    Console.WriteLine("Login Successfull");
                    break;                   
                }                   

                //IList<IWebElement> lstTdElem = elemTr.FindElements(By.TagName("td"));
                //if (lstTdElem.Count > 0)
                //{
                //    foreach (var elemTd in lstTdElem)
                //    {
                //        string rowData = elemTd.Text;
                //        //Console.WriteLine(username +  " and " + rowData);
                //        if (rowData == username)
                //        {
                //            Console.WriteLine("Login Successfull");
                //            //Assert.AreEqual(username, rowData);
                //        }

                //    }
            //}

        } 

        }

        [TearDown]

        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
