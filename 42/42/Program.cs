using System;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x != y)
            {
                if (x < y)
                {
                    x = (x + y) / 2;
                    y = 2 * x * y;
                }
                else if (x > y)
                {
                    y = (x + y) / 2;
                    x = 2 * x * y;
                }
            }
           
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
