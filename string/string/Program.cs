using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая строка: ");
            String str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Вторая строка: ");
            String str1 = Convert.ToString(Console.ReadLine());
            Clas perv = new Clas("");
            Clas s1 = new Clas(str);
            Clas s2 = new Clas(str1);
            Console.WriteLine("Действие: (==)найти ел, (_)длинна , (+)соеденить строки");
            String sym = Convert.ToString(Console.ReadLine());
            if (sym == "==") perv.Search(s1,s2);
            if (sym == "_") perv.Length(s1,s2);
            if (sym == "+") Console.WriteLine(s1.str + s2.str);
        }
    }
    class Clas
    {
        public string str;

        public Clas(string text)
        {
            str = text;
        }
        public void Search(Clas s1, Clas s2)
        {
            Console.WriteLine("Введите нужный символ");
            char symb = Convert.ToChar(Console.ReadLine());
            String poz1 = " ";
            String poz2 = " ";
            for (int i = 0; i < s1.str.Length; i++)
            {
                if (symb == s1.str[i])
                Console.WriteLine("Символ: " + symb + " стоит на: " + (i+1) + " позиции, " + s1.str + " строке");
                poz1 += i + 1 + " ";
            }
           
            for (int i = 0; i < s2.str.Length; i++)
            {
                if (symb == s2.str[i])
                Console.WriteLine("Символ: " + symb + " стоит на: " + (i + 1) + " позиции, " + s2.str + " строке");
                poz2 += i + 1 + " ";
            }
  
        }
        public void Length(Clas s1, Clas s2)
        {
            Console.WriteLine("Длина 1 строки:" + s1.str.Length);
            Console.WriteLine("Длина 2 строки:" + s2.str.Length);
        }
        public static Clas operator +(Clas s1, Clas s2)
        {
            return new Clas("")
            {
                str = s1.str + s2.str
            };
        }
    }
}
