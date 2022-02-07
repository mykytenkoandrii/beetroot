using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonDataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.X = numbers.GetUserValue();
            numbers.Y = numbers.GetUserValue();
            numbers.CountSum(numbers.X, numbers.Y);
            Console.Read();
        }
    }
    class Numbers
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string errorMessage = "Invalid input. Please, input correct integer!";

        //Get user integer with exception
        public int GetUserValue()
        {
            string userInput;
            Console.WriteLine("Input integer for sum range:");
            userInput = Console.ReadLine();
            try
            {
                return Convert.ToInt32(userInput);
            }
            catch (FormatException)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(errorMessage);
                return GetUserValue();
            }
        }

        //Count the sum of all numbers between
        public void CountSum(int X, int Y)
        {
            if (X == Y)
            {
                Console.WriteLine("Numbers are equal! Sum is {0}", X);
            }
            else
            {
                int maxValue = Math.Max(X, Y);
                int minValue = Math.Min(X, Y);
                Console.WriteLine("Min value: {0}, Max value: {1}", minValue, maxValue);
                int sum = minValue;
                while(minValue != maxValue)
                {
                    ++minValue;
                    sum += minValue; 
                }
                Console.WriteLine("The sum of X and Y is {0}", sum);
            }
        }
    }
}
