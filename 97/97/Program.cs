using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _97
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = Convert.ToInt32(Console.ReadLine());
            double x = 1;
            double y = 1;
            double sum = x / (1 + Math.Abs(y));
            for (i = 2; i <= n; i++)
            {
                y = x + y;
                x = 0.3 * x;
                sum = sum + x / (1 + Math.Abs(y));

            }
            Console.WriteLine(sum);
        }
    }
}
