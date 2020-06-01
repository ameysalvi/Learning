using SpecflowIntro.Step_Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SpecflowIntro
{
    [Binding]
    class SampleFeatureStep
    {
        public readonly EmployeeDetails employee;

        public SampleFeatureStep(EmployeeDetails emp)
        {
            this.employee = emp;

        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers); 
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 121)
                Console.WriteLine("The test PASSED");
            else
            {
                Console.WriteLine("The test FAILED");
                throw new Exception("The Value is differnt");
            }    
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                employee.Age = (int)item.Age;
                employee.Email = (string)item.Email;
                employee.Name = (string)item.Name;
                employee.Phone = (long)item.Phone;

            }
        }


        [When(@"I fill all the mandatory detials in form")]
        public void WhenIFillAllTheMandatoryDetialsInForm(Table table)
        {


            //var details = table.CreateSet<EmployeeDetails>();

            // foreach (EmployeeDetails emp in details)
            // {
            //     Console.WriteLine("*************************************");
            //     Console.WriteLine("The Details for Employee :" + emp.Name);
            //     Console.WriteLine("*************************************");
            //     Console.WriteLine(emp.Age);
            //     //Console.WriteLine(emp.Name);
            //     Console.WriteLine(emp.Email);
            //     Console.WriteLine(emp.Phone);
            // }

            //var details = table.CreateDynamicSet();
            //foreach (var emp in details)
            //{
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine("The Details for Employee :" + emp.Name);
            //    Console.WriteLine("*************************************");
            //    Console.WriteLine(emp.Age);
            //    //Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine(emp.Phone);
            //}


        }

        [When(@"I fill all the mandatory detials in form (.*), (.*) and (.*)")]
        [Obsolete]
        public void WhenIFillAllTheMandatoryDetialsInFormAmeyAnd(String name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);

            ScenarioContext.Current["InfoforNextStep"] = "Step1 Passed";

            Console.WriteLine(ScenarioContext.Current["InfoforNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "Amey0",
                    Age = 30,
                    Email = "amey0@gmail.com",
                    Phone =1234564879
                },
                new EmployeeDetails()
                {
                    Name = "Amey1",
                    Age = 31,
                    Email = "amey1@gmail.com",
                    Phone =8756451313
                },
                new EmployeeDetails()
                {
                    Name = "Amey2",
                    Age = 32,
                    Email = "amey2@gmail.com",
                    Phone =346574894321
                }
            };

            //Save the value in ScenarioContext
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value out from ScenarioContext
            var emplist = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The Employee Name is : " + emp.Name);
                Console.WriteLine("The Employee Age is : " + emp.Age);
                Console.WriteLine("The Employee Email is : " + emp.Email);
                Console.WriteLine("The Employee Phone is : " + emp.Phone);
                Console.WriteLine("\n");
            }

            Console.WriteLine();
        }

    }
}
