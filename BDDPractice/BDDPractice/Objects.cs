using BDDPractice.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPractice
{
    public class Objects
    {
        IWebDriver driver = null;
        public Objects(IWebDriver driver)
        {
            this.driver = driver;

        }

        // get  returns the value of the variable
        //set  assigns a value to the variable
        public static UserDetailsObject objUserDetails { get; set; }
        public static LoginObject objLogin { get; set; }

        public void ObjectInitialization()
        {
            objUserDetails = new UserDetailsObject(driver);
            objLogin = new LoginObject(driver);
        }
    }
}
