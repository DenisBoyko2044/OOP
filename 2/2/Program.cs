using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double rezult = (Math.Abs(x) - Math.Abs(y)) / (1 + Math.Abs(x * y));
            Console.WriteLine(rezult);
        }
    }
    }
}
