using System;
using System.Collections.Generic;
using System.Threading;

namespace printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Do print = new Do();
            for (int i = 0; i < 10; i++, Thread.Sleep(1000))
                print.NewUser();
            print.Go();
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Num { get; set; }
    }
    class Prior
    {
        public string Name { get; set; }
        public int Num { get; set; }
    }
    class Info
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public string Prioritet { get; set; }
    }
    class Do
    {
        int num=0;
        Queue<User> persons = new Queue<User>();
        User user; 
        Queue<Prior> Prioritet = new Queue<Prior>();
        Prior personPrioritet;
        Queue<Info> stat = new Queue<Info>();
        Info stats;
        String userName = "";
        int prioritety = 0;
        int f;
        public void NewUser()
        {
            Random rnd = new Random();
            f = rnd.Next(1, 6);
            if (f == 1)
                userName = "Oleg";
            else if (f == 2)
                userName = "Mihail";
            else if (f == 3)
                userName = "Sergey";
            else if (f == 4)
                userName = "Kirill";
            else if (f == 5)
                userName = "Denis";
            prioritety = rnd.Next(1, 3);
            if (prioritety == 2)
            {
                num++;
                persons.Enqueue(new User() { Name = userName, Num = num });
            }
            else 
            {
                num++;
                Prioritet.Enqueue(new Prior() { Name = userName, Num = num });
            }
        }
        public void Go()
        {
            int i=1;
            while (i==1)
            {
                if (Prioritet.Count != 0)
                {
                    personPrioritet = Prioritet.Dequeue();
                    stat.Enqueue(new Info() { Name = personPrioritet.Name, Num = personPrioritet.Num, Prioritet = "1" });

                }
                else if (Prioritet.Count == 0 && persons.Count != 0)
                {
                    user = persons.Dequeue();
                    stat.Enqueue(new Info() { Name = user.Name, Num = user.Num, Prioritet = "2" });
                }
                else
                    i++;
                while (stat.Count != 0)
                {
                    stats = stat.Dequeue();
                    Console.WriteLine("Имя: " + stats.Name + "\nЗаявка №: " + stats.Num + "\nПриоритет: " + stats.Prioritet + "\n");
                }
            }
        }

    }


}


