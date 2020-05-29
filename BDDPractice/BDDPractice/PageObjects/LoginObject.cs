using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDPractice.PageObjects
{
    public class LoginObject
    {
        private IWebDriver driver;

        public LoginObject(IWebDriver driver)
        {
            this.driver = driver;

        }
    }
}
