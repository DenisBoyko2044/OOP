using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double maximum = Math.Max(a, b);
            double minimum = Math.Min(a, b);

            Console.WriteLine(maximum);
            Console.WriteLine(minimum);

        }
    }
}
