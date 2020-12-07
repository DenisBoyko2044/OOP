using System;

namespace _66
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            if (k < m * m)
            {
                x = Math.Abs(x);
                y = y - 0.5;
                z = z - 0.5;
            }
            if (k == m * m)
            { 
              y = Math.Abs(y);
            x = x - 0.5;
            z = z - 0.5;
        }
            if (k == m* m)
            {
                z = Math.Abs(z);
                x = x - 0.5;
                y = y - 0.5;
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
