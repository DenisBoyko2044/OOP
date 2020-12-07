using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[100];
            for (int a = 1; a<arr.Length;a++)
            {
                arr[a] = (3 * a + 4) / (a * a - 5 * a - 9);
                Console.WriteLine("Arr[" + a + "] = " + arr[a]);
            }
        }
    }
}
