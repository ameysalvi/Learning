using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro.Step_Definitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employee;

        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;

        }

        [Then(@"I should get the same value from extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("The Details for Employee :" + employee.Name);
            Console.WriteLine("*************************************");
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Phone);
        }


    }
}
