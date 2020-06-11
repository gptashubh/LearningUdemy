using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //Create a deriving class boss with the propertie CompanyCar and the method Lead(). 
    //Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHourse and a method Learn().
    class Boss : Employee
    {

        public  string Companycar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary): base(name,firstName,salary)
        {
            this.Companycar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I'm {0} {1} ,Designation : Boss and have car of company {2}",this.Name, this.FirstName, this.Companycar);
        }
    }
}
