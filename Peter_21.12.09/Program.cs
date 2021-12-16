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
            //3.Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!
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


            //4.feladat Írj programot, ami beolvas két számot, majd kiírja:
            Console.Write("Kérem adjon meg egy 4.feladathoz egyik számot: ");
            int szam4 = int.Parse(Console.ReadLine());

            Console.Write("Kérem adjon meg egy 4.feladathoz egyik számot: ");
            int szam5 = int.Parse(Console.ReadLine());

            int osszeguk = szam4 + szam5;
            int kulonbseguk = szam4 - szam5;
            int szorzatuk = szam4 * szam5;
            double hanyadossuk = szam4 / szam5 / 10.0;

            Console.WriteLine($"A két szám összege: {osszeguk}\nA két szám különbsége: {kulonbseguk}\nA két szám szorzata: {szorzatuk}\nA két szám hányadosa: {hanyadossuk}");

            //Szabály: Ha két egész számot osztok, annak mindig lebegőpontos lesz az eredménye
            //azaz NEM EGÉSZ SZÁM!

            //5.feladat: Írj programot, mely beolvas két egész számot,
            //és kiírja a képernyőre a nagyobbikat!
            Console.Write("Adj meg egy számot az 5.feladathoz:");
            int szam6 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg még egy számot az 5.feladathoz:");
            int szam7 = int.Parse(Console.ReadLine());

            if (szam6 > szam7)
            {
                Console.WriteLine($"A {szam6} nagyobb, mint {szam7}");
            }
            else
            {
                    Console.WriteLine($"A {szam7} nagyobb, mint {szam6}");
            }

            //6.feladat: Írj programot, mely beolvas három egész számot,
            //és kiírja a képernyőre a legkisebbet!
            Console.Write("Adj meg egy számot az 6.feladathoz:");
            int szam8 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg még egy másik számot az 6.feladathoz:");
            int szam9 = int.Parse(Console.ReadLine());
            Console.Write("Adj meg még egy harmadik számot az 6.feladathoz:");
            int szam10 = int.Parse(Console.ReadLine());
            if (szam8 < szam9 && szam8 < szam10) 
            {
                Console.WriteLine($"A {szam8} a legkisebb szám!");
            }
            else if(szam9<szam10)
            {
                Console.WriteLine($"A {szam9} a legkisebb szám!");
            }
            else
            {
                Console.WriteLine($"A {szam10} a legkisebb szám!");
            }

            Console.ReadKey();
        }
    }
}
