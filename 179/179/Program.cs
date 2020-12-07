using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _179
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rand.Next(-100, 100);
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] / 2) % 2 != 0) Console.WriteLine("a = " + arr[i]);
                if ((arr[i] % 7 == 1) || (arr[i] % 7 == 2) || (arr[i] % 7 == 5)) Console.WriteLine("b = " + arr[i]);


            }
        }
    }
}
