using System;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {

                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Convert.ToInt32(Console.ReadLine());
            if (a < b || b < c)
                Console.WriteLine("да");
            else if (a > b || b > c)
                Console.WriteLine("ne");
            else if (a == b || b == c)
                Console.WriteLine("так незя");
        }
    }
}
