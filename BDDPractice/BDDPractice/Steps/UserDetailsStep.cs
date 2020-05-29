using BDDPractice.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDPractice.Steps
{
    [Binding]
    public class UserDetailsStep
    {
        // TestClass obj = new TestClass();

        //  obj = new Objects(Driver.browser.driver, Driver.browser);

        //   public static TestClass browser { get; set; }

        [Given(@"I am on Sign In Page")]
        public void GivenIAmOnSignInPage()
        {
            Objects.objUserDetails.enterSearchKeyword();
        }

        [Then(@"I the valid credentials in the Username and Password field")]
        public void ThenITheValidCredentialsInTheUsernameAndPasswordField()
        {

        }

        [Then(@"click on the Sign In button")]
        public void ThenClickOnTheSignInButton()
        {

        }

    }
}
