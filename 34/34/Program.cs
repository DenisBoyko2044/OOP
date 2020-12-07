using System;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b || b < c)
                Console.WriteLine("да");
            else
                Console.WriteLine("ne");
        }
    }
}
