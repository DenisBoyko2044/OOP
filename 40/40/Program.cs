using System;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            if (x <= y)
                x = 0;
            Console.WriteLine(x);
         
        }
    }
}
