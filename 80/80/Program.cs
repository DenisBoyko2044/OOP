using System;

namespace _80
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            int fact=1;
            double s=x;
            for (int i = 1; i <= 13; i+=4)
            {
                fact = fact * i;
                s = (s - (Math.Pow(x, i))/fact)*(-1);
            }
            Console.WriteLine(s);
        }
    }
}
