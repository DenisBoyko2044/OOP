using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            int n = 5;
            int h_mark = 5 * m;
            double t = (n <= h_mark) ? 12.0 * (h_mark - 11.0 * n / 12) / 11 : 12.0 * (60 - 11.0 * n / 12 + h_mark) / 11;
            Console.WriteLine(t);
        }
    }
}
