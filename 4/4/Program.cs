using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double SerAr = (a + b) / 2;
            double SerGer = Math.Sqrt(a * b);
            Console.WriteLine(SerAr);
            Console.WriteLine(SerGer);
        }
    }
}
