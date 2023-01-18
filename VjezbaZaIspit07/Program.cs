using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- PRVI ZADATAK -----");
            /*
             * Napišite program koji će ispisati sve prijestupne godine u razdoblju od (uključujući) 1900. do (uključujući) 2100. 
             * Prijestupne godine su one koje su djeljive sa 400 plus one koje su djeljive sa 4, ali ne i sa 100.
             */

            for (int i = 1900; i < 2101; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 100 == 0 && i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("\n----- ZADATAK 2 -----");
            /*
             * Napišite program koji će za unešeni niz znakova pronaći znak koji se pojavljuje najviše puta,
               te će i izračunati taj broj (npr. VODOVOD -> O, 3 puta).*/

            string nizZnakova;
            char znak = ' ';
            int xH = 0, maxH = 0;
            Console.WriteLine("Unesi niz znakova: ");
            nizZnakova = Console.ReadLine();
            for(int i = 0; i < nizZnakova.Length; i++)
            {
                for(int j = 0; j < nizZnakova.Length; j++)
                {
                    if(nizZnakova[i] == nizZnakova[j])
                    {
                        xH++;
                        if (xH > maxH)
                        {
                            znak = nizZnakova[i];
                            maxH = xH;
                        }
                    }
                   
                }
                
            }
            Console.WriteLine("Znak {0} {1} puta", znak, xH);



            Console.WriteLine("\n----- ZADATAK 3 -----");
            /*
             * Napišite program koji će zatražiti od korisnika da unese neki pozitivni broj, 
             * te će ispisati sve brojeve manje od tog broja na sljedeći način: npr. za unešeni broj 5 treba ispisati:
                1
                12
                123
                1234
            */

            int broj;
            Console.WriteLine("Unesi pozitivan broj: ");
            broj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= broj; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
