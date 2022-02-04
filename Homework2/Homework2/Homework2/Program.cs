using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Number
    {
        public double x { get; set; }
        public double y { get; set; }

        //-6*x^3+5*x^2-10*x+15
        public void Exercise()
        {
            double result = (-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15);
            OutputResult("-6*x^3+5*x^2-10*x+15", result);
        }

        //abs(x)*sin(x)
        public void Exercise2()
        {
            double result = Math.Abs(x) * (double)Math.Sin(x);
            OutputResult("abs(x)*sin(x)", result);
        }

        //2*pi*x
        public void Exercise3()
        {
            double result = 2 * Math.PI * x;
            OutputResult("2*pi*x", result);
        }
        //max(x, y)
        public void Exercise4()
        {
            double result = Math.Max(x, y);
            if (x == y)
            {
                Console.WriteLine("Numbers x and y are equal!");
            }
            
            OutputResult("max(x, y)", result);
        }

        //result output
        public void OutputResult(string expression, double x)
        {
            Console.WriteLine("The result of expression '{0}' is {1:f}\n", expression, x);
        }
    }

    class DateManipulation
    {
        public static DateTime DateTime {
            get {
                return DateTime.Now;
            }

            set {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
            }
        }

        public static int DayOfYear
        {
            get { return DayOfYear; }
            set { DayOfYear = DateTime.DayOfYear; }
        }

        public static void GetCurrentDay()
        {
            Console.WriteLine("Today is {0} day of current {1} year\n", DateTime.DayOfYear, DateTime.Year);
        }

        public static void GetDaysToNewYear()
        {
            int year = DateTime.Year;
            int daysToNewYear;
            int daysInYear;
            if (year%4 == 0)
            {
                daysInYear = 366;
            }
            else
            {
                daysInYear = 365;
            }
            daysToNewYear = daysInYear - DateTime.DayOfYear;
            Console.WriteLine("Days to New Year remains: {0}", daysToNewYear);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine("Please, enter number x: ");
            number.x = Convert.ToDouble(Console.ReadLine());
            number.Exercise();
            number.Exercise2();
            number.Exercise3();
            Console.WriteLine("Please, enter number y: ");
            number.y = Convert.ToDouble(Console.ReadLine());
            number.Exercise4();
            DateManipulation.GetCurrentDay();
            DateManipulation.GetDaysToNewYear();
            Console.Read();
        }
    }
}
