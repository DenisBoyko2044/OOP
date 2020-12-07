using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, f = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (k = 0; k <= n; k++)
            {
                if (f = f * k)
                sum = sum + Math.Pow(-1, k * (k - 1) * 2) / f;
            }
            Console.WriteLine(sum);
        }
    }
}
