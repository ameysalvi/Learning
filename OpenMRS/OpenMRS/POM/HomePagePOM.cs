using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS.POM
{
    public class HomePagePOM
    {
        private IWebDriver driver;

        public HomePagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void GoogleSearch()
        {
            IWebElement UserName = driver.FindElement(By.Name("q"));
            UserName.SendKeys("Testing");
        }
        
    }
}
