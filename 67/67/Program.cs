using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n<=100)
            {
                if (n < 10) Console.WriteLine("Одна цифра");
                else if ((n >= 10) & (n != 100))
                {
                    Console.WriteLine("Дві цифри");
                    int a1 = n % 10;
                    int a2 = (n - a1) / 10;
                    int sum = a1 + a2;
                    Console.WriteLine(sum);
                    Console.WriteLine(a1);
                    Console.WriteLine(a2);
                    Console.WriteLine(a2);

                }
                else if (n == 100)
                {
                    Console.WriteLine("3 цифри");
                    int a1 = 1;
                    int a2 = 0;
                    int a3 = 0;
                    int sum = a1 + a2 + a3;
                    Console.WriteLine(sum);
                    Console.WriteLine(a3);
                    Console.WriteLine(a1);
                    Console.WriteLine(a2);

                }
            }
        }
    }
}
