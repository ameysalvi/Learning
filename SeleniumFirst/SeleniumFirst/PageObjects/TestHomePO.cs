using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class TestHomePO
    {
        public TestHomePO()
        {
            //PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle'][contains(text(),'Input Forms')]")]
        public IWebElement lnkMenuInputForm{ get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[contains(text(),'Simple Form Demo')]")]
        public IWebElement lnkSubMenuSimpleFormDemo { get; set; }

        [FindsBy(How = How.LinkText, Using = "No, thanks!")]
        public IWebElement adPopupCancelButton { get; set; }

        //IWebElement adPopupCancelButton = PropertiesCollection.driver.FindElement(By.LinkText("No, thanks!"));

        public void adHandle()
        {     
            if (adPopupCancelButton.Displayed == true)
            {
                adPopupCancelButton.Clicks();
            }
        }

        public void ClickMenu()
        {
            //SeleniumSetMethods.Click(lnkMenuInputForm);
            lnkMenuInputForm.Clicks();
        }

        public BasicFirstFormDemoPO ClickSubMenu()
        {
            //SeleniumSetMethods.Click(lnkSubMenuSimpleFormDemo);
            lnkSubMenuSimpleFormDemo.Clicks();
            return new BasicFirstFormDemoPO();
        }
    }
}
