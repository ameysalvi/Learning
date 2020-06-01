using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumGetMethods
    {
        public static string GetText(this IWebElement element)
        {
            return element.Text;
        }

        public static string GetTextDDL(this IWebElement element, string value)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
