using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter your name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Your full name is {0} {1}", student.Name, student.Surname);
            Console.Read();
        }
    }
}
