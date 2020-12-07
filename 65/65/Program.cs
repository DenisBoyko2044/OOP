using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _65
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n <= 99) & (n > 9))
            {
                int a1 = n % 10;
                int a2 = n - a1;
                if (Math.Pow(n, 2) == Math.Pow(a1 + a2, 3))
                    Console.WriteLine("Верно");
            }
            else if ((n <= 9) & (n > -1))
            {
                if (Math.Pow(n, 2) == Math.Pow(n, 3))
                    Console.WriteLine("Верно");
            }
            else Console.WriteLine("Невірне число");
        }
    }
}
