using System;

namespace qwweeeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int maxq = Math.Max(x, y);
            int maximum = Math.Max(maxq, z);
            int minq = Math.Min(x, y);
            int minimum = Math.Min(minq, z);
            Console.WriteLine(maximum);
            Console.WriteLine(minimum);
        }
    }
}
