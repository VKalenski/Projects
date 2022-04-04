using System;

namespace Concrete_Column
{
    class Program
    {
        static void Main(string[] args)
        {
            double fck = 25;   // in N/mm^2
            double fyk = 500;  // in N/mm^2
            double acc = 0.85;  // in N/mm^2
            double yc = 1.50;  // in N/mm^2
            double ys = 1.15;  // in N/mm^2
            double fcd = (fck * acc) / yc;  // in N/mm^2
            double fyd = fyk / ys;  // in N/mm^2
            Console.WriteLine($"Defining: fck = {fcd:F2} N/mm^2");
            Console.WriteLine($"Defining: fyd = {fyd:F2} N/mm^2");

            int number = int.Parse(Console.ReadLine());
            NewMethod(number);
        }

        private static int NewMethod(int number)
        {
            Console.WriteLine(number);
            return number;
        }
    }
}
