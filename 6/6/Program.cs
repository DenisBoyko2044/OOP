using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double S = (a * b) / 2;
            Console.WriteLine(c);
            Console.WriteLine(S);
        }
    }
}
