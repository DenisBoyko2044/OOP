using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _139
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[5];
            
           
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 1;
               a[i] = i*i;
                Console.WriteLine(a[i]);
            }
            
           

        }
    }
}
