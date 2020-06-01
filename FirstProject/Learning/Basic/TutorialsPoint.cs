using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using OpenQA.Selenium.Support.UI;

namespace Learning
{
    class TutorialsPoint
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

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm");
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void tutorialsPointTest()
        {
            //First Name
            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.SendKeys("Testy");
            //Thread.Sleep(3000);

            //Last Name
            IWebElement lastName = driver.FindElement(By.Name("lastname"));
            lastName.SendKeys("Tester");
            //Thread.Sleep(3000);

            //Sex
            List<IWebElement> sexList = new List<IWebElement>(driver.FindElements(By.XPath("//input[@name='sex']")));
            foreach (IWebElement element in sexList)
            {
                if (element.Selected == false)
                {
                    element.Click();
                    //Thread.Sleep(3000);
                }

            }

            //Experience            
            List<IWebElement> expList = new List<IWebElement>(driver.FindElements(By.XPath("//input[@name='exp']")));
            foreach (IWebElement element in expList)
            {
                if (element.Selected == false)
                {
                    element.Click();
                    //Thread.Sleep(3000);
                }

            }

            //Date
            IWebElement date = driver.FindElement(By.XPath("//tr[5]//td[2]//input[1]"));
            date.SendKeys("10/10/1980");
            //Thread.Sleep(3000);

            //Profession
            List<IWebElement> professionList = new List<IWebElement>(driver.FindElements(By.XPath("//input[@name='profession']")));
            foreach (IWebElement element in professionList)
            {
                if (element.Selected == false)
                {
                    element.Click();
                    //Thread.Sleep(3000);
                }

            }

            //Photo
            IWebElement photo = driver.FindElement(By.Name("photo"));

            //JaveScript Executor is used
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", photo);
            //Thread.Sleep(3000);
            //js.ExecuteScript("arguments[0].value = 'C:\\Automation\\Learning\\Learning\\Learning\\IMG_20170507_192235_973'",photo);

            //Using AutoIT
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(3000);
            autoIt.Send("C:\\Automation\\Learning\\Learning\\Learning\\IMG_20170507_192235_973");
            autoIt.Send("{Enter}");
            //Thread.Sleep(1000);

            //Tools
            List<IWebElement> toolList = new List<IWebElement>(driver.FindElements(By.XPath("//input[@name='tool']")));
            foreach (IWebElement element in toolList)
            {
                if (element.Selected == false)
                {
                    element.Click();
                    //Thread.Sleep(3000);
                }

            }

            //Continents 
            var continents = driver.FindElement(By.Name("continents"));
            var selectContinents = new SelectElement(continents);
            List<IWebElement> continentsList =  new List<IWebElement> (selectContinents.Options);
            int continentCount = continentsList.Count();
            for(int i=0 ; i < continentCount; i++)
            {
                selectContinents.SelectByIndex(i);
                //Thread.Sleep(3000);
            }


            //Selenium Commands
            var selenium_commands = driver.FindElement(By.Name("selenium_commands"));
            var selectSeleniumCommands = new SelectElement(selenium_commands);
            List<IWebElement> seleniumCommandsList = new List<IWebElement>(selectSeleniumCommands.Options);
            int seleniumCommandsCount = seleniumCommandsList.Count();
            for (int i = 0; i < seleniumCommandsCount; i++)
            {
                selectSeleniumCommands.SelectByIndex(i);
                //Thread.Sleep(3000);
            }

            //Button
            IWebElement submitButton = driver.FindElement(By.Name("submit"));
            submitButton.Click();
            Thread.Sleep(3000);
                        
            driver.SwitchTo().Alert().Accept();

            

        }

        [TearDown]

        public void closeBrowser()
        {
            //driver.Quit();
        }

        #region archive    
        //IWebElement exp1 = driver.FindElement(By.XPath("//span[contains(text(),'1')]"));
        //String exp1IsSelected = exp1.Selected.ToString();
        //if (exp1IsSelected == "False")
        //{
        //    exp1.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp1IsSelected);

        //IWebElement exp2 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='2']"));
        //String exp2IsSelected = exp2.Selected.ToString();
        //if (exp2IsSelected == "False")
        //{
        //    exp2.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp2IsSelected);

        //IWebElement exp3 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='3']"));
        //String exp3IsSelected = exp3.Selected.ToString();
        //if (exp3IsSelected == "False")
        //{
        //    exp3.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp3IsSelected);

        //IWebElement exp4 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='4']"));
        //String exp4IsSelected = exp4.Selected.ToString();
        //if (exp4IsSelected == "False")
        //{
        //    exp4.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp4IsSelected);

        //IWebElement exp5 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='5']"));
        //String exp5IsSelected = exp5.Selected.ToString();
        //if (exp5IsSelected == "False")
        //{
        //    exp5.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp5IsSelected);

        //IWebElement exp6 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='6']"));
        //String exp6IsSelected = exp6.Selected.ToString();
        //if (exp6IsSelected == "False")
        //{
        //    exp6.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp6IsSelected);

        //IWebElement exp7 = driver.FindElement(By.XPath(".//input[@name='exp' and @value='7']"));
        //String exp7IsSelected = exp7.Selected.ToString();
        //if (exp7IsSelected == "False")
        //{
        //    exp7.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(exp7IsSelected);

        //IWebElement profession = driver.FindElement(By.XPath("//span[contains(text(),'Automation Tester')]"));
        //if (profession.Enabled)
        //{
        //    String professionIsSelected = profession.Selected.ToString();
        //    Console.WriteLine(professionIsSelected);
        //    profession.Click();
        //    Thread.Sleep(3000);
        //    String professionIsSelected1 = profession.Selected.ToString();
        //    Console.WriteLine(professionIsSelected1);
        //}

        //IWebElement professionMT = driver.FindElement(By.CssSelector("table > tbody > tr:nth-child(6) > td:nth-child(2) > span:nth-child(1) > input[type=checkbox]"));

        //IWebElement sexMale = driver.FindElement(By.XPath(".//input[@name='sex' and @value='Male']"));
        //String sexMaleIsSelected = sexMale.Selected.ToString();
        ////Console.WriteLine(sexMaleIsSelected);

        //if (sexMaleIsSelected == "False")
        //{
        //    sexMale.Click();
        //}
        ////Thread.Sleep(3000);

        //IWebElement sexFemale = driver.FindElement(By.XPath(".//input[@name='sex' and @value='Female']"));
        //String sexFemaleIsSelected = sexMale.Selected.ToString();
        ////Console.WriteLine(sexFemaleIsSelected);
        //if (sexFemaleIsSelected == "True")
        //{
        //    sexFemale.Click();
        //    //Thread.Sleep(3000);
        //}
        ////Console.WriteLine(sexMaleIsSelected);

        //Using AutoIT
        //Thread.Sleep(3000);
        //IWebElement photoUpload = driver.FindElement(By.Name("photo"));
        //photoUpload.Click();

        //AutoItX3 autoIt = new AutoItX3();
        //autoIt.WinActivate("Open");

        //autoIt.Send(@"C:\Automation\Learning\Learning\Learning");
        //Thread.Sleep(1000);
        //autoIt.Send("{Enter}");

        #endregion archive


    }
}
