using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            double kvadr = Math.Pow(2, n);
            Console.WriteLine("2 в степени " + n + " = " +kvadr);
            int fakt = 1;
            for (int i = 1; i<=n;i++)
            {
                 fakt = fakt * i;
            }
            Console.WriteLine("Факториал с " + n + " = " + fakt);

            double rezult = 1;
            for (int i = 1;i<=n;i++)
            {
                rezult *= 1 + (1 / (i*i));
            }
            Console.WriteLine("Ответ на В  = " + rezult);

            double Y = 0 ;
            for (int i = 1;i<=n;i++)
            {
                Y += 1 / Math.Sin(i);
            }
            Console.WriteLine("Ответ на Г  = " + Y);

            double rezultD = 1;
            for (int i = 1; i <= n; i++)
            {
                rezultD = Math.Sqrt(2 + rezultD);
            }
            Console.WriteLine("Ответ на Д  = " + rezultD);

            double rezultE = 1;
            for (int i = 1; i <= n; i++)
            {
                rezultE *= Math.Cos(i) / Math.Sin(i);
            }
            Console.WriteLine("Ответ на E  = " + rezultE);

            double rezultG = 1;
            for (int i = 1; i <= n; i++)
            {
                rezultG *= Math.Sqrt(3 * (i - 1) + Math.Sqrt(3 * i + rezultG));
            }
            Console.WriteLine("Ответ на Ж  = " + rezultG);


        }
    }
}
