using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double maximum = Math.Max(x+y+z, x*y*z);
            
            double minimum = Math.Sqrt(Math.Min((x+y+z)/2, x*y*z)+1);
            Console.WriteLine(maximum);
            Console.WriteLine(minimum);
            //35
        }
    }
}
