using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPractice.PageObjects
{
    public class UserDetailsObject
    {
        private IWebDriver driver;

        public UserDetailsObject(IWebDriver driver)
        {
            this.driver = driver;           
        }

        public void enterSearchKeyword()
        {
            driver.FindElement(By.Name("q")).SendKeys("test");
        }

    }
}
