using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSharpBasic
{
    class TestClass1
    {
        public void Add()
        {
            Console.WriteLine("Empty add method");
        }

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            //Console.WriteLine("add method two parameters and result is " + result);
            return result;
        }

        public static void ReadXml()
        {
            XmlReader xml = XmlReader.Create(@"C:\Automation\Learning\Learning\Learning\TestDataAccess\product.xml");

            while (xml.ReadToFollowing("Product"))
            {
                XElement element = (XElement)XElement.ReadFrom(xml);

                string productId = element.Element("Product_id").Value;
                string productName = element.Element("Product_name").Value;
                string productPrice = element.Element("Product_price").Value;

                Console.WriteLine($"{productId} {productName} {productPrice}");

            }

        }
   

        //public static void ReadXml(string productId)
        //{
        //    XmlTextReader xml = new XmlTextReader(@"C:\Automation\Learning\Learning\Learning\TestDataAccess\product.xml");
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(xml);

        //    foreach (XmlNode temp in doc)
        //    {

        //    }


        //}

        //while (xml.Read())
        //{
        //    if (xml.Name.Equals("Product_id") && (xml.NodeType == XmlNodeType.Element))
        //    {
        //        xml.readto
        //        var productId = xml.Value;
        //        //String productId = xml.GetAttribute("Product_id");
        //        //string productName = xml.GetAttribute("Product_name");
        //        //string productPrice = xml.GetAttribute("Product_price");
        //        //Console.WriteLine($"{productId} {productName} {productPrice}");

        //    }

        //}



        //XmlDocument xmlDoc = new XmlDocument();
        //xmlDoc.Load(@"C:\Automation\Learning\Learning\Learning\TestDataAccess\product.xml");

        //foreach (XmlNode node in xmlDoc.DocumentElement)
        //{
        //    foreach (XmlNode childNode in node)
        //    {
        //        Console.WriteLine($"The Xml node is {childNode.Name} and its value is {childNode.InnerText}");
        //    }

    


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


    #region archive
    //private int i = 0;
    //public void SetValue(int value)
    //{
    //    i = value;
    //}

    //public void GetValue()
    //{
    //    Console.WriteLine("The value of i is : "  + i);
    //}

    //public void TestCase1(string result)
    //{
    //    Console.WriteLine("Executing Testcase 1 " + result);
    //}
    //public void TestCase2(string result)
    //{
    //    Console.WriteLine("Executing Testcase 2 " + result);
    //}
    #endregion
