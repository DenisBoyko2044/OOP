﻿using System;
using System.Collections.Generic;

namespace lr222
{
    class Abon
    {
        public string Pib;
        public int number;
        public int teleph;
        public string info;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abonent vcx = new Abonent();
            vcx.Menu();
            vcx.GiveInfo();
            vcx.GetInfo();
        }
        }
        public class Abonent
        {
    
        List<Abon> abon = new List<Abon>();

        public void GiveInfo()
        {
            
            Console.WriteLine("Pib");
            String Pib = Console.ReadLine();
           
                Console.WriteLine("number");
            int number = Convert.ToInt32(Console.ReadLine());
        
                Console.WriteLine("teleph");
            int teleph = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("info");
            String info = Console.ReadLine();
   
            abon.Add(new Abon() { Pib = Pib, number = number, teleph = teleph, info = info });
        }

        public void GetInfo()
        {
            foreach (Abon klient in abon)
                Console.WriteLine($"Клиент: {klient.Pib}  Номер: {klient.number} Телефон: {klient.teleph}  Инфо: {klient.info}");
        }
        public void Menu()
        {
           
            Console.WriteLine("Оберіть команду: (add) - Новий абонент; (all) - Всі абоненти");
            String Choice = Console.ReadLine();
        
               if(Choice=="add")
                        GiveInfo();
                         Console.WriteLine("Оберіть команду: (add) - Новий абонент; (all) - Всі абоненти");
                Choice = Console.ReadLine();
        
                if (Choice == "all")
                    Console.WriteLine("Абоненти в телефонній книзі:");
                        GetInfo();
                         Console.WriteLine("Оберіть команду: (add) - Новий абонент; (all) - Всі абоненти");
                          Choice = Console.ReadLine();

                
            }
        }
    }
