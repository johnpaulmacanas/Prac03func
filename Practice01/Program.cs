using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Legths of the Triangle");
            Console.Write("Enter the 1st side:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 2nd side:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 3rd side:");
            double c = Convert.ToDouble(Console.ReadLine());

            double area = CalcuArea(a, b, c);

            Console.WriteLine($"The area of the triangle is {area}");
        }

        static double CalcuArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}