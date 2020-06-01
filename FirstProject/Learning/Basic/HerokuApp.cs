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
    class HerokuApp
    {
        IWebDriver driver;
        string baseUrl = "https://the-internet.herokuapp.com/login";        

        public void Login(string username,string password)
        {
            IWebElement iweUsername = driver.FindElement(By.Id("username"));
            IWebElement iwePassword = driver.FindElement(By.Id("password"));
            IWebElement iweloginBtn = driver.FindElement(By.CssSelector("div.row:nth-child(2) div.large-12.columns:nth-child(2) div.example form:nth-child(3) button.radius:nth-child(3) > i.fa.fa-2x.fa-sign-in"));

            iweUsername.SendKeys(username);
            iwePassword.SendKeys(password);
            iweloginBtn.Click();

            Thread.Sleep(3000);

            BannerRead();
        }

        public void BannerRead()
        {
            IWebElement iweErrorBanner = driver.FindElement(By.Id("flash"));
            string strErrorBannerTest = iweErrorBanner.Text;

            
            if (iweErrorBanner.Displayed)
            {
                if (strErrorBannerTest.Contains("You logged into a secure area!"))
                {
                    
                    Console.WriteLine("Login Successfull " + strErrorBannerTest);
                    Thread.Sleep(3000);
                    Logout();
                }
                else if (strErrorBannerTest.Contains("Your username is invalid!") || strErrorBannerTest.Contains("Your password is invalid!"))
                {
                    Assert.AreEqual(iweErrorBanner.Text.Trim(), "Your username is invalid!\r\n×");
                    Console.WriteLine("Login Fail " + strErrorBannerTest);
                }
                else if (strErrorBannerTest.Contains("You logged out of the secure area!"))
                {
                    Console.WriteLine("Logout Successfully " + strErrorBannerTest);
                    
                }
                else
                {
                    Console.WriteLine("Smothing has happen " + strErrorBannerTest);
                }
            }
            else
            {
                Console.WriteLine("There is banner, but some error or something has happen.");
            }            
        }
        
        public void Logout()
        {
            IWebElement logout = driver.FindElement(By.ClassName("button"));
            logout.Click();
            BannerRead();
        }        

        public void LinkClick()
        {
            IWebElement iwelink = driver.FindElement(By.LinkText("Elemental Selenium"));
            iwelink.Click();
            Thread.Sleep(3000);
                        
            var browserTabs = driver.WindowHandles;
            driver.SwitchTo().Window(browserTabs[1]);

            if (driver.Url == "http://elementalselenium.com/http://elementalselenium.com/" && driver.Title == "")
            {
                Console.WriteLine("Page redirected to element selenium at" + driver.Url + " and Title is " + driver.Title);
            }

            //string strPageSource = driver.PageSource;
            //string newUrl = "http://elementalselenium.com";            
            //if(strPageSource.Contains(newUrl))
            //{
            //    Console.WriteLine("Page redirected to " + newUrl);
            //}
        }

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
        public void HerokuAppTest()
        {
            //Both Blank
            Console.WriteLine("Both Blank");
            Login("", "");

            ////Password Blank
            //Console.WriteLine("Password Blank");
            //Login("tomsmith", "");

            ////Username Blank
            //Console.WriteLine("Username Blank");
            //Login("", "SuperSecretPassword!");

            ////Invalid password
            //Console.WriteLine("Invalid password");
            //Login("tomsmith", "adfdsfdsfdsfd!");

            ////Invalid username
            //Console.WriteLine("Invalid username");
            //Login("sadsadsad", "SuperSecretPassword!");

            ////Valid Credentials
            //Console.WriteLine("Valid Credentials");
            //Login("tomsmith", "SuperSecretPassword!");

            ////Click on the link
            //LinkClick()

        }
       
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
