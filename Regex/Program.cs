using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\\Users\\shugupta3\\Documents";
            Console.WriteLine("What is your name?\n");
           var read= Console.ReadLine();

            if (File.Exists(filename))
            { File.Delete(filename); }

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                StreamWriter streamWriter = new StreamWriter(filename, true);
                streamWriter.WriteLine(read);

            }



        }
    }
}
