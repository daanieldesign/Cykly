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

            /*int pocet = 10;
            int soucet = 0;
            int max = 0;

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Zadejte číslo:");
                /*
                int cislo = Convert.ToInt32(Console.ReadLine());
                soucet += cislo;

                if (cislo > max)
                {
                    max +=1;
                }
            }
*/
            /*
                        Console.WriteLine("Součet čísel je: " + soucet);
                        Console.WriteLine("Největší číslo ze všech zadaných čísel je: " + max);



                            Console.WriteLine("Kolikrát?");
                            int x = Convert.ToInt16(Console.ReadLine());
                            int i = 0;
                            do
                            {
                                Console.WriteLine(i);
                                i++;
                            } while (i < x);
                            */

            /* Console.WriteLine("Chcete pokračovat? Y/N");
             int x = Convert.ToInt16(Console.ReadLine());
             if (x == 'Y')
             {
                 do
                 {
                     i++;
                 } while (i < x);
             }*/

            /*
            
            string odpoved;
            {
                Console.WriteLine("Chcete pokračovat?");
                odpoved = Console.ReadLine();
            } while (odpoved == "ano");

            Console.WriteLine("Děkuji za použití aplikace.");
            */

            //součet 10 desetinných čísel
            /*string odpoved;
            do
            {
                float soucet = 0; //Vynulování součtu pro opakování sečtení čísel
                for (int i = 0; i < 10; i++)
                {
                    soucet += float.Parse(Console.ReadLine()); //přičtu číslo k součtu
                    Console.WriteLine("Součet: " + soucet);
                    Console.WriteLine("Chcete pokračovat? Y/N");
                }
                //do while proběhne jen jednou a poté vyhodnotí

                    odpoved = Console.ReadLine();
            }while (odpoved == "Y");*/

            //Výběr největšího čísla z 10 čísel
            string odpoved;
            do
            {
                float cislo = 0;
                float max = 0;
                float min = 0;
                Console.WriteLine("Napište 10 čísel. Program následně vybere nejvetší zadané číslo a vypíše ho: ");
                for (int i = 0; i < 10; i++)
                {
                    cislo = float.Parse(Console.ReadLine());
                    if (cislo > max)
                    {
                        max = cislo;
                    } 
                    if (cislo < min)
                    {
                        min = cislo;
                    }
                }
                Console.WriteLine("Největší číslo je: " + max);
                Console.WriteLine("Nejmenší číslo je: " + min);
                Console.WriteLine("Chcete pokračovat? y/n");
                odpoved = Console.ReadLine();
            } while (odpoved == "y");

            Console.WriteLine("Díky.");

        Console.ReadKey();
            }

    }
}
