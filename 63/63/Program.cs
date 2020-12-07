using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            int r = 3;
            int s = 1;
            if (a % b == r)
            Console.WriteLine("Esli r - da");
            else Console.WriteLine("Esli r - net");
            if (a % b == s)
                Console.WriteLine("Esli s - da");
            else Console.WriteLine("Esli s - net");

        }
    }
}
