using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class CollectionExample
    {

        //NonGenericCollection();
        //GenericCollections();
        //GenericCollectionsWithCustomClass();


        public static void ArrayExample()
        {
            int[] count = new int[] { 101, 102, 103, 104, 105, };

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }

            string[] name = new string[] { "a", "b", "c", "d" };

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }

        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "ea123");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The value for " + key + " is: " + table[key]);
            }

            //Console.WriteLine("The UserName is: " + table["UserName"]);
            //Console.WriteLine("The Password is: " + table["Password"]);
            //Console.WriteLine("The Button is: " + table["Button"]);
        }

        public static void GenericCollections()
        {
            string[] user1 = new string[] { "amey", "30", "amey@gmail.com", "212564" };
            string[] user2 = new string[] { "amey1", "31", "amey1@gmail.com", "214564" };
            string[] user3 = new string[] { "amey2", "32", "amey2@gmail.com", "212897" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                string[] usersInfo = value.Value;

                foreach (var user in usersInfo)
                {
                    Console.WriteLine(user);
                }

            }
        }

        public static void GenericCollectionsWithCustomClass()
        {
            List<User> users = new List<User>();
            users.Add(new User { UserId = 1, Name = "Amey0", Age = 30, Email = "amey0@gmail.com", Phone = 21313546, Addresses = new List<Address>() { new Address { Street = "Street1", Country = "Malaysia", FlatName = "1" }, new Address { Street = "Office1", Country = "Malaysia", FlatName = "11" } } });
            users.Add(new User { UserId = 2, Name = "Amey1", Age = 31, Email = "amey1@gmail.com", Phone = 548789564, Addresses = new List<Address>() { new Address { Street = "Street2", Country = "US", FlatName = "2" }, new Address { Street = "Office2", Country = "US", FlatName = "12" } } } );
            users.Add(new User { UserId = 3, Name = "Amey2", Age = 30, Email = "amey2@gmail.com", Phone = 789564654 , Addresses = new List<Address>() { new Address { Street = "Street3", Country = "UK", FlatName = "3" } , new Address { Street = "Office3", Country = "UK", FlatName = "13" } } });

            //foreach (var user in users)
            //{
            //    Console.WriteLine(string.Format("The User {0} with Age {1} has Email {2} and Phone {3}", user.Name, user.Age, user.Email, user.Phone));
            //}

            //Linq query based expression
            var userlist = from user in users
                           from address in user.Addresses
                           where user.Age == 30
                           select new { FirstName = user.Name, PhoneNumber = user.Phone, Address = address };

            ////Linq methods based expression
            //var userlist = users.Where(x => x.Age == 30).SelectMany(x => x.Addresses);

            foreach (var user in userlist)
            {
                Console.WriteLine("User {0} has Phone number {1} with country {2}", user.FirstName , user.PhoneNumber,user.Address.Country);
            }

            #region Different method of setting the data
            //List<User> users = new List<User>()
            //{
            //    new User
            //    {
            //        UserId = 1,
            //        Name = "Amey0",
            //        Age = 30 ,
            //        Email = "amey0@gmail.com",
            //        Phone = 21313546
            //    },

            //    new User
            //    {
            //        UserId = 2,
            //        Name = "Amey1",
            //        Age = 31 ,
            //        Email = "amey1@gmail.com",
            //        Phone = 548789564
            //    },

            //    new User
            //    {
            //        UserId = 3,
            //        Name = "Amey2",
            //        Age = 32 ,
            //        Email = "amey2@gmail.com",
            //        Phone = 789564654
            //    },
            //};
            #endregion

        }

    }
    //This is custom type class for user data
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 Phone { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Address
    {
        public string FlatName { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
    }

    #region archive
    //class1.TestCase1("PASSED");
    //class1.TestCase2("FAILED");

    //class1.SetValue(20);
    //class1.GetValue();
    //class1.SetValue(50);
    //TestClass1 class2 = new TestClass1();
    //class2.SetValue(30);
    //class2.GetValue();

    //class1.GetValue();

    //Console.Write("Hello Automation");
    //NewMethod();

    //private static void NewMethod()
    //{
    //    TestClass1 class1 = new TestClass1();

    //    //implicit convertion
    //    Int16 salary = 23434;
    //    int salaryincere = salary;
    //    salaryincere = 1032485784;

    //    double incomeTax = 23434.15465d;

    //    Console.WriteLine((int)incomeTax);

    //    Console.Read();
    //}

    //TestClass1 testClass = new TestClass1();
    //int result = testClass.Add(12, 12);
    //testClass.Add();
    //Console.WriteLine(result + 10);
    #endregion

    #region condition statement
    //string testCaseState = "PASSED";

    //        if (testCaseState == "PASSED")
    //            Console.WriteLine("Test Case PASSED");
    //        else if (testCaseState == "FAILED")
    //            Console.WriteLine("Test Case FAILED");
    //        else if (testCaseState == "HOLD")
    //            Console.WriteLine("Test Case HOLD");

    //        switch (testCaseState)
    //        {
    //            case "PASSED":
    //                {
    //                    Console.WriteLine("Test Case PASSED");
    //                    break;
    //                }
    //            case "FAILED":
    //                {
    //                    Console.WriteLine("Test Case FAILED");
    //                    break;
    //                }
    //            case "HOLD":
    //                {
    //                    Console.WriteLine("Test Case HOLD");
    //                    break;
    //                }
    //            default:
    //                {
    //                    Console.WriteLine("The case is not any of these");
    //                    break;
    //                }                    
    //        }
    #endregion

    #region looping

    //for (int i = 0; i < 10; i++)
    //{
    //    Console.WriteLine("The number of time is: " + i);
    //}

    //bool temp = true;
    //int i = 0;

    //while (temp)
    //{
    //    Console.WriteLine("Number: " + i);
    //    if (i == 4)
    //    {
    //        temp = false;
    //    }

    //    i++;
    //}

    #endregion
}

