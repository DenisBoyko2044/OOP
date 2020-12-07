using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double s1;
            double s2=a;
            double s3=1;
            double s4=a;

            s1 = Math.Pow(a, n);
            
                for(int i = 0; i<n;i++)
                {
                s2 = 1/(s2 * (a + i));
                 }

            for (int i = 0; i < n; i++)
                {
                s3 = s3 + 1 /Math.Pow(a,2*i);
                }

            for (int i = 0; i <= n; i++)
            {
                s4 = s4*(a-i);
            }


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
