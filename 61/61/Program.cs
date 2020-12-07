using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6.7356;
            double cel = Math.Truncate(x) ;
            Console.WriteLine(cel);
            double ork = Math.Round(x);
            Console.WriteLine(ork);



        }
    }
}
