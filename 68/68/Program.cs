using System;

namespace _68
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            int c;
            int d;
            if(n<=9999)
            {
                a = n / 1000;
                Console.WriteLine(a);
                b = a /10 %10;
                Console.WriteLine(b);
                c = b / 100  %10;
                Console.WriteLine(c);
                d = c % 10;
                Console.WriteLine(d);
                if (a == b && c == d)
                  
                    Console.WriteLine(n);
            }    
        }
    }
}
