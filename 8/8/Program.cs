using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());

            double perimetr = 2 * r * n * Math.Sin(Pi / n) * Math.Cos(Pi / n);

            Console.WriteLine(perimetr);
        }
    }
}
