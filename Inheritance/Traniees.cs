using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    ////Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHourse and a method Learn()
    class Traniees : Employee
    {
        public int WorkingHour { get; set; }
        public int SchoolHour { get; set; }
        public Traniees( int workingHour, int schoolHour, string name, string firstName, int salary): base(name,firstName,salary)
        {
            this.WorkingHour = workingHour;
            this.SchoolHour = schoolHour;
        }

        public void learn()
        {
            Console.WriteLine("I'm learning for {0} ", this.SchoolHour);
        }
         public new void work()
        {
            Console.WriteLine("I'm working for {0} ", this.WorkingHour);
        }
    }
}
