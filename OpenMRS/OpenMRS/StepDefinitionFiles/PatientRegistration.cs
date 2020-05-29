using NUnit.Framework;
using OpenMRS.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace OpenMRS.StepDefinitionFiles
{
    [Binding]
    public class PatientRegistration
    {

        [Given(@"OpenMRS site is open in a browser")]
        public void GivenOpenMRSSiteIsOpenInABrowser()
        {
            Thread.Sleep(2000);
            AllPageObjects.objHomePage.GoogleSearch();
            Thread.Sleep(2000);
        }

        [Given(@"I enter admin username")]
        public void GivenIEnterAdminUsername()
        {
            //IWebElement UserName = driver.FindElement(By.Id("username"));
            //UserName.SendKeys(ConfigurationManager.AppSettings.Get("Username"));
        }

        [Given(@"I enter admin password")]
        public void GivenIEnterAdminPassword()
        {
            
        }

        [When(@"I select Registration Desk location")]
        public void WhenISelectRegistrationDeskLocation()
        {
            
        }

        [When(@"I press Log In button")]
        public void WhenIPressLogInButton()
        {
            
        }

        [Then(@"I should be able to login into the Registration Desk with Super User or Admin")]
        public void ThenIShouldBeAbleToLoginIntoTheRegistrationDeskWithSuperUserOrAdmin()
        {
            
        }

    }
}
