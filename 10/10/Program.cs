using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.80665;
            double h = Convert.ToDouble(Console.ReadLine());
            double t = Math.Sqrt((2 * h) / g);

            Console.WriteLine(t);
        }
    }
}
