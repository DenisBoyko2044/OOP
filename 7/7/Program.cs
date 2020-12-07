using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            const double P = 1000;
            double m1 = Convert.ToDouble(Console.ReadLine());
            double t1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double t2 = Convert.ToDouble(Console.ReadLine());
            double Tc = (m1 * t1 + m2 * t2) / (m1 + m2);
            double v = (m1 + m2) / P;
            Console.WriteLine(Tc);
            Console.WriteLine(v);
        }
    }
}
