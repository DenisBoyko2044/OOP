using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double V = Math.Pow(a, 3);
            double S = Math.Pow(a, 2);
            Console.WriteLine(V);
            Console.WriteLine(S);
        }
    }
}
