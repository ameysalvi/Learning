using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Learning.TestDataAccess
{
    class ReadDataXML
    {




        public void ReadXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Automation\Learning\Learning\Learning\TestDataAccess\product.xml");

            foreach (XmlNode node in xmlDoc)
            {
                Console.WriteLine(node);
            }

            //var xmlFile = XDocument.Load(@"C:\Automation\Learning\Learning\Learning\TestDataAccess\product.xml");
            //var query = from xml in xmlFile.Root.Descendants("Product")
            //            where (int)xml.Attribute("Product_id") <= 4
            //            select xml.Value;

            //foreach (var data in query)
            //{
            //    Console.WriteLine($"The xml data is: Product{data}");
            //}

        }


        

    }
}
