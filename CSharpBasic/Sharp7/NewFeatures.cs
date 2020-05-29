using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Sharp7
{

    public class NewFeatures
    {
        public List<Students> students = null;

        public NewFeatures()
        {
            var s = new List<Students>
            {
                new Students()
                {
                    Name = "Amey",
                    Age = 20,
                    Gender = "M",
                    Grade = "First"
                },

                new Students()
                {
                    Name = "Amey1",
                    Age = 30,
                    Gender = "M",
                    Grade = "Second"
                },

                new Students()
                {
                    Name = "Amey2",
                    Age = 40,
                    Gender = "M",
                    Grade = "Third"
                }
            };

            students = s;
        }

        public void GetStudentsInfoWithGrade(Students student)
        {
            switch (student)
            {
                case Students s when (s.Grade == "First" && s.Name.Contains("Am")):
                    Console.WriteLine($"Student with Name {s.Name} is with Age {s.Age}");
                    break;
                case Students s when (s.Grade == "Thrid"):
                    Console.WriteLine($"Student with Name {s.Name} is with Age {s.Age}");
                    break;
                default:
                    break;
            }
        }

        public (string name, int age, string grade) ReturnStudentInfo()
        {
            return ("Amey", 30, "A");
        }

        public void GetStudentsDetials(out string name, out int age, out string grade)
        {
            name = "Amey";
            age = 30;
            grade = "A";
        }
    }

    public class Students
    {
        public Students(string name) => Name = name;

        public Students()
        {

        }

        private int _salary;

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Gender { get; set; }

        public string GetStudentName()
        {
            return Name ?? throw new TypeInitializationException("CSharpBasic.Students.Name",new Exception("Name has to be initialised before calling it"));
        }

        public void PrintName() => Console.WriteLine($"The name of Student is {Name}");
    }
}
