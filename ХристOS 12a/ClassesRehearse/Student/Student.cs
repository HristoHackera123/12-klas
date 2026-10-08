using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {
        private int age;
        public string Name { get; set; }
        public int Age { 
            get {return age;} 
            set {
                if(value is int && value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be a non-negative integer.");
                }
            } 
        }
        public string Grade { get; set; }
        public Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}
