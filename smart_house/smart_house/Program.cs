using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smart_house;


namespace smart_house
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Koliko uređaja se nalazi u pametnoj kući?\n> ");
            int br_uredjaja = Convert.ToInt16(Console.ReadLine());
            Uredjaj[] uredjaji = new Uredjaj[br_uredjaja];

            for (int i = 0; i < uredjaji.Length; i++)
            {
                Console.WriteLine("Unesite podatke o " + (i + 1) + ". Uređaju:\n\t(1-Ventilator, 2-Grijalica i 3-Klima uređaj)");
                int tip = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tNaziv> ");
                string naziv = Console.ReadLine();
                Console.Write("\tIP adresa> ");
                string adresa = Console.ReadLine();
                switch (tip)
                {
                    case 1:
                        uredjaji[i] = new Ventilator(naziv, adresa);
                        break;
                    case 2:
                        Console.Write("Temperatura> ");
                        int temperatura = Convert.ToInt32(Console.ReadLine());
                        uredjaji[i] = new Grijalica(naziv, adresa, temperatura);
                        break;
                    case 3:
                        Console.Write("Temperatura> ");
                        int temperatura2 = Convert.ToInt32(Console.ReadLine());
                        uredjaji[i] = new KlimaUredjaj(naziv, adresa, temperatura2);
                        break;
                }

            }

            for (int i = 0; i < uredjaji.Length - 1; i++)
                for (int j = i + 1; j < uredjaji.Length; j++)
                {
                    if (uredjaji[i] == false && uredjaji[j] == true)
                    {
                        Uredjaj pom = uredjaji[i];
                        uredjaji[i] = uredjaji[j];
                        uredjaji[j] = pom;
                    }
                }

            Console.WriteLine("Uredjaji posle sortiranja su:");
            foreach (Uredjaj U in uredjaji)
            {
                Console.WriteLine(U.ToString());
            }
            Console.ReadKey();
        }
    }
}
