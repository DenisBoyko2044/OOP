using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
          double a = Convert.ToDouble(Console.ReadLine());
          double b = Convert.ToDouble(Console.ReadLine());
          double z = Convert.ToDouble(Console.ReadLine());
            
            if ((a >= b) & (b >= z))
            {
                a *= a;
                b *= b;
                z *= z;
                a = Math.Abs(a);
                b = Math.Abs(b);
                z = Math.Abs(z);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(z);
            }
                
            }
        }
    }

