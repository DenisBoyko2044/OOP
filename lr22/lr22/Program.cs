using System;

namespace lr22
{
    class Program
    {
        static void Main(string[] args)
        {
            Abonent vcx = new Abonent();
            vcx.GiveInfo();
            vcx.GetInfo();
          // Abonent vcxz = new Abonent();
            // vcxz.GiveInfo();
          //  vcxz.GetInfo();
           /*
            Abonent vcxzz = new Abonent(3);
            vcxzz.GiveInfo();
            vcxzz.GetInfo();
          */
        }
    }
public class Abonent
    {
        public string Pib;
        public int number;
        public int teleph;
        public string info;

        /*
        public Abonent(int number)
        {
        Pib = "Ковбаса Петро Петрович";
        number =1223;
         }

        public Abonent(string line)
        {
             Pib = "Ковбаса Петро Петрович";
            number =1223;
            teleph=00000000;
            info="Звичайний абонент";
    }

        */

        public void GiveInfo()
        {
            if (Pib == null)
            {
                Console.WriteLine("Pib");
                Pib = Console.ReadLine();
            }
            if (number == null)
            {
                Console.WriteLine("number");
                number = Convert.ToInt32(Console.ReadLine());
            }
            if (teleph == null)
            {
                Console.WriteLine("teleph");
                teleph = Convert.ToInt32(Console.ReadLine());
            }
            if (info == null)
            {
                Console.WriteLine("info");
            info = Console.ReadLine();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Клиент: {Pib}  Номер: {number} Телефон: {teleph}  Инфо: {info}");
        }
      
    }
     
}

