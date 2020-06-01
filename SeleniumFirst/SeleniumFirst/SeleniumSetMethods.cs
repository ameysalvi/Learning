using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click option for Button, Checkbox, option etc
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
