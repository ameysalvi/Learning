using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.Selenium;
using CSharpBasic.Browsers;
using CSharpBasic.ExtensionMethods;
using CSharpBasic.Delegates;
using CSharpBasic.Sharp7;

namespace CSharpBasic
{

    enum Browser
    {
        Firefox,
        Chrome,
        IE,
        Safari
    }
    class Program
    {

        //https://www.youtube.com/playlist?list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx
        static void Main(string[] args)
        {
            NewFeatures feature = new NewFeatures();
            //feature.GetStudentsInfoWithGrade(feature.students.First());

            //(string StudentName, int StudentAge, String StudentGrade)  = feature.ReturnStudentInfo();

            //if(StudentAge == 30)
            //    Console.WriteLine($"The student with {StudentName} and age {StudentAge} and Grade {StudentGrade}");


            ////feature.GetStudentsDetials(out string name, out int age, out string grade);
            ////Console.WriteLine($"The student with {name} and age {age} and Grade {grade}");

            //Students s = new Students("Amey");
            ////s.Name = "Amey";

            ////Console.WriteLine($"Name of the student is: {s.GetStudentName()}");

            //s.PrintName();

            TestClass1.ReadXml();

            Console.Read();

            #region Delegates
            //Console.WriteLine(GetBrowserName(Browser.Chrome));

            //IWebDriver driver = new IE();
            //driver.SendKeysWithSpecialChar("Testing","@!");

            //CollectionExample.GenericCollectionsWithCustomClass();

            ////Delegate example C# 3.5
            //Func<string, string> p = delegate (string values)
            //{
            //    return values;
            //};
            //Console.WriteLine($"The value printed from Func<> delegate is {p("Testing")}");

            //Action<string> actionp = delegate (string values)
            //{
            //    Console.WriteLine($"The value printed from Action<> delegate is {values}");
            //};
            //actionp("Testing");

            //Action<string> actionwithLambda = values => { Console.WriteLine($"This value prineted from Action<> with Lambda {values}"); };
            //actionwithLambda("Testing");


            ////Delegate example C# 3.0
            //Printer p = (values) => { Console.WriteLine($"The value printed from Lambda Expressioin is {values}"); };
            //p("Testing");

            ////Delegate example C# 2.0
            //Printer p = delegate (string values)
            //{
            //    Console.WriteLine($"The value printed in line is{values}");
            //};
            //p("Testing");

            ////Delegate example C# 1.0
            //Printer p = DelegateTry.PrintValue1;
            //p("Testing");
            #endregion
        }

        #region Browser
        //public static string GetBrowserName(Browser browser)
        //{
        //    if (browser == Browser.Firefox)
        //        return "firefox is open";
        //    else if (browser == Browser.Chrome) 
        //        return "chrome is open";
        //    else
        //        return "IE is open";
        //}
        #endregion
    }


}
 