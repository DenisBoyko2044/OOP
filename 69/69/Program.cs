using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69
{
    class Program
    {
        static void Main(string[] args)
        {
            double  u, h, m;
            double fi = Convert.ToDouble(Console.ReadLine());
            do
            {
                m = Math.Truncate(fi * 2 * 180 / 3.14);
                 h = m % 60;
                m = m % 60;

            }
        }
    }
}
