using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double[] a = new double[n];
            double rezA = 0;
            double rezB = 1;
            double rezV = 0;
            double rezG = 1;
            double rezL = 1;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rand.Next(-100, 100);
            for (int i = 0; i < n; i++)
            {
                rezA += a[i];
                rezB *= a[i];
                rezV += Math.Abs(a[i]);
                rezG *= Math.Abs(a[i]);
                rezL *= Math.Sqrt(Math.Abs(a[i]));
            }
                Console.WriteLine("a = " + rezA);
                Console.WriteLine("б = " + rezB);
                Console.WriteLine("в = " + rezV);
                Console.WriteLine("г = " + rezG);
                Console.WriteLine("л = " + rezL);
         }
    }
}
