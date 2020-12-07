using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a < 0) Console.WriteLine(Math.Pow(a, 2));
            if (b < 0) Console.WriteLine(Math.Pow(b, 2));
            if (c < 0) Console.WriteLine(Math.Pow(c, 2));

        }
    }
}
