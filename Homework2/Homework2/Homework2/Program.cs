using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Number{
        public float x { get; set; }
        public float y { get; set; }
        public float maxValue {
            get {
                if (x > y)
                    return x;
                else
                    return y;
            }
            set { x = x; y = y; }
        }

        //-6*x^3+5*x^2-10*x+15
        public void Exercise()
        {
            float result = (-6 * (float)Math.Pow(x, 3) + 5 * (float)Math.Pow(x, 2) - 10 * x + 15);
            OutputResult("-6*x^3+5*x^2-10*x+15", result);
        }

        //abs(x)*sin(x)
        public void Exercise2()
        {
            float result = Math.Abs(x) * (float)Math.Sin(x);
            OutputResult("abs(x)*sin(x)", result);
        }

        //2*pi*x
        public void Exercise3()
        {
            float result = 2 * (float)Math.PI * x;
            OutputResult("2*pi*x", result);
        }
        //max(x, y)
        public void Exercise4()
        {
            OutputResult("max(x, y)", maxValue);
        }

        //result output
        public void OutputResult(string expression, float x)
        {
            Console.WriteLine("The result of expression '{0}' is {1}", expression, x);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine("Please, enter number x: ");
            number.x = Convert.ToInt32(Console.ReadLine());
            number.Exercise();
            number.Exercise2();
            number.Exercise3();
            Console.WriteLine("Please, enter number y: ");
            number.y = Convert.ToInt32(Console.ReadLine());
            number.Exercise4();
            Console.Read();
        }
    }
}
