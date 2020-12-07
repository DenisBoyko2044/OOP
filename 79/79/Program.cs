using System;

namespace _79
{
    class Program
    {
        static void Main(string[] args)
        {
      
            double b=0;
            double c=1;

            for (int i = 0; i <= 100; i++)
            {
                b = c*(1+Math.Sin(i/10));
                    }
            Console.WriteLine(b);
        }
    }
}
