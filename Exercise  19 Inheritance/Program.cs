namespace Exercise__19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Employee joe = new Employee("Joe", 25, 1234, "Sales Rep");
            // joe.DisplayPersonInfo();
            Manager carl = new Manager("Carl", 35, 5678, "Sales Manager", 10);
            carl.DisplayManagerInfo();
        }

        public class Person
        {
            public string Name { get; private set; }
            public int Age { get; private set; }
            // Base class constructor

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Person constructer called");
            }

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"Person information: Name: {Name}, Age: {Age}");
            }

            }
        public class Employee : Person
        {
            public int EmployeeID { get; private set; }
            public string JobTitle { get; private set; }
            public Employee(string name, int age, int employeeID, string jobTitle) : base(name, age) //Call the base class constructor
            {
                EmployeeID = employeeID;
                JobTitle = jobTitle;
                Console.WriteLine("Emloyee (Derived Class) Constructer called");
            }

        }

        public class Manager : Employee
        {
            public int TeamSize { get; private set; }
            public Manager(string name, int age, int employeeID, string jobTitle, int teamSize) : base(name, age, employeeID, jobTitle)
            {
                TeamSize = teamSize;
                
            }

            public void DisplayManagerInfo()
            {
                DisplayPersonInfo();
                Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID},Team Size: {TeamSize} ");
            }
        }
    }
}



