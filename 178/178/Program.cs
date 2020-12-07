using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _178
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int nA = 0;
            int nB = 0;
            int nV = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 100);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) nA = nA + 1;
                if (arr[i]%3==0 & arr[i]%5!=0) nB = nB + 1;
                if (Math.Sqrt(arr[i]) % 2 == 0) nV = nV + 1;
            }
            Console.WriteLine("a = " + nA);
            Console.WriteLine("б = " + nB);
            Console.WriteLine("в = " + nV);
        }
    }
}
