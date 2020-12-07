using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1 = Convert.ToDouble(Console.ReadLine());
            double r2 = Convert.ToDouble(Console.ReadLine());
            double r3 = Convert.ToDouble(Console.ReadLine());
            double R = (1 / (1 / r1 + 1 / r2 + 1 / r3));
            Console.WriteLine(R);
        }
    }
}
