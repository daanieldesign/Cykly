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
            //Cyklus s nekonečným počtem opakování
            //Cyklus s podmínkou na začátku, pokud není splněna podmínka, tak se ani nespustí
            int counter = 0;
            while (true) //Vyhodnocování podmínky
            {
                //Příkaz
                counter = counter + 1;
                Console.WriteLine(counter);
            }

            Console.WriteLine("Podmínka nebyla splněna a dostal jsem se tady!");
            Console.ReadKey();
        }
    }
}
