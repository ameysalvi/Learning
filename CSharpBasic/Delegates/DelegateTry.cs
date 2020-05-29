using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Delegates
{
    //Declaration for a Delegate
    //delegate void Printer(string printValue);

    class DelegateTry
    {
        public static void PrintValue(string values)
        {
            Console.WriteLine($"The Value is {values}");
        }

        //public static void PrintValue1(string values, int salary)
        //{
        //    Console.WriteLine($"The Value is from PrintValue1 {values}");
        //}

    }
}
