using System;

namespace _38a
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 0;
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
                z = x - y;
            else if (x < y)
                z = y - x + 1;
            Console.WriteLine(z);
        }
    }
}
