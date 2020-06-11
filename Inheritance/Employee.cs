using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inheritance
{
    class Employee 
    {
        //Create a main class with a Main Method, then a base class Employee with the properties Name, FirstName, Salary 
        //and the methods Work() and Pause().


        // properties
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {
            Name = "Shubham";
            FirstName = "Gupta";
            Salary = 50000;
        }

        public Employee(string name, string firstName, int salary)
        {
           this.Name = name;
           this.FirstName = firstName;
           this.Salary = salary;
        }

        public void work()
        {
            Console.WriteLine("working\n");
        }
       
        public void pause()
        {
            Console.WriteLine("Paused\n");
        }
    }
}
