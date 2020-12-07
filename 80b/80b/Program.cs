using System;

namespace _80b
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            int fact = 1;
            double s = x;
            int n = 13;
            for (int i = 1; i <n; i+=2)
            {
                fact = fact * i;
                s = (s - (Math.Pow(x, i)) / fact) * (-1);
              
            }
            Console.WriteLine(s);
        }
    }
}
