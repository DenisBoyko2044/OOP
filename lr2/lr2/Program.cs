using System;

namespace lr2
{
    public class Abonent
    {
        public string Pib;
        public int number;
        public int teleph;
        public string info;

        public void GetInfo()
        {
            Console.WriteLine($"Клиент: {Pib}  Номер: {number} Телефон{teleph}  Инфо{info}");
        }
    }
    class Prog {
        static void Main(string[] args)
        {
            Abonent vcx = new Abonent();
            vcx.Pib = Console.ReadLine();
            vcx.number = Convert.ToInt32(Console.ReadLine());
            vcx.teleph = Convert.ToInt32(Console.ReadLine());
            vcx.info = Console.ReadLine();
            vcx.GetInfo();
        }
    
}
}
