using CSharpBasic.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Browsers
{
    class IE : IWebDriver
    {
        public void FindElement()
        {
            Console.WriteLine("Find the UI element in IE");
        }

        public void Click()
        {
            Console.WriteLine("Click the element in IE");
        }

        public void SendKeys(string keys)
        {
            Console.WriteLine("Send the text in IE" + keys);
        }
    }
}
