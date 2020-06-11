using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee shubham = new Employee( "Shubham","Gupta",5000);
            shubham.work();
            shubham.pause();

            Boss boss = new Boss("Audi", "Nik", "Kapo", 100000);
            boss.Lead();
            Console.ReadKey();

        }
    }
}
