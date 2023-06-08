using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Cyklus s nekonečným počtem opakování
            //Cyklus s podmínkou na začátku, pokud není splněna podmínka, tak se ani nespustí
            int counter = 0;

            Console.WriteLine("Chcete zapnout nekonečný cyklus? True/False");
            bool starter = bool.Parse(Console.ReadLine());

            while (starter) //Vyhodnocování podmínky
            {
                //Příkaz
                counter = counter + 1;
                Console.WriteLine(counter);
            }

            Console.WriteLine("Podmínka nebyla splněna a dostal jsem se tady!");

            //Cyklus s pevným počtem opakování
            //for(počáteční hodnota, podmínka, příkaz)
            //i++ –> inkrementace, přičtení o jedna
            //i-- –> dekrementace, snížení o jedna
            //Cyklus for má řídící proměnnou, kolikrát se má cyklus vykonat
            Console.WriteLine("Napište počet opakování:");
            int x = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }*/

            /*
            int pocet = 10;
            int soucet = 0;
            int max = 0;

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Zadejte číslo:");
                int cislo = Convert.ToInt32(Console.ReadLine());
                soucet += cislo;

                if (cislo > max)
                {
                    max +=1;
                }
            }


            Console.WriteLine("Součet čísel je: " + soucet);
            Console.WriteLine("Největší číslo ze všech zadaných čísel je: " + max);

            */

            //Úkol 2 – Program, který napíše počet kladných, záporných čísel a nul

            int nula = 0;
            int kladne = 0;
            int zaporne = 0;
            Console.Write("Vyberte počet čísel, se kterými chcete pracovat: ");
            int pocet = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < pocet; i++)
            {
                
                Console.Write("Napište nyní " + pocet + "x číslo, které chcete použít k seřazení: ");
                float cislo = float.Parse(Console.ReadLine());

                if (cislo == 0)
                {
                    nula += 1;
                }
                else if (cislo > 0) {
                    kladne += 1;
                }
                else if (cislo < 0)
                {
                    zaporne += 1;
                }
            }

            Console.WriteLine("Počet nul: " + nula);
            Console.WriteLine("Počet kladných čísel: " + kladne);
            Console.WriteLine("Počet záporných čísel: " + zaporne);
            
            Console.ReadKey();
        }
    }
}
