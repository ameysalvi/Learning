using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS.POM
{
    class AllPageObjects
    {
        IWebDriver driver = null;

        public AllPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static HomePagePOM objHomePage { get; set; }

        public void ObjectInitialization()
        {
            objHomePage = new HomePagePOM(driver);
        }

    }
}
