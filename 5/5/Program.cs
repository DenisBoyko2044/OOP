using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double SerAr = (a + b) / 2;
            double SerGer = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
            Console.WriteLine(SerAr);
            Console.WriteLine(SerGer);
        }
    }
}
