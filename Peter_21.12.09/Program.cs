using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_21._12._09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!
            Console.Write("Kérem adjon meg egy számot: ");
            double szam = double.Parse(Console.ReadLine());
            Console.WriteLine("A beolvasott szám kétszerese: " + 2*szam);

            /*Írj programot, ami beolvas két számot, majd kiírja:
            *a.az összegüket;
            *b.különbségüket;
            *c.szorzatukat;
            *d.hányadosukat, ha lehet!
            **/
            Console.Write("Adj meg egy számot: ");
            double szam2 = double.Parse(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            double szam3 = double.Parse(Console.ReadLine());
            Console.WriteLine("számok összeg: "+(szam2+szam)+ "\nkülönbségük: "+(szam2-szam3)+ "\nszorzatuk: "+(szam2*szam3)+"\nhányadosuk: "+(szam2/szam3));


            Console.ReadKey();
        }
    }
}
