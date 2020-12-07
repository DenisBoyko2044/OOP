using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            int sum1 = 0;
            int sum2 = 0;
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rand.Next(-100, 100);
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 5 == 0) sum1 += arr[i];
                if (arr[i] % 2 != 0 & arr[i] < 0) sum2 += arr[i];
            }
            Console.WriteLine("a = " + sum1);
            Console.WriteLine("б = " + sum2);
        }
    }
}
