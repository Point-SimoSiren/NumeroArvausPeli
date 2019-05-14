using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palautettava_Arvauspeli ///Tehnyt: Simo Sirén koulutehtävänään
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean ok = false;                        //Esitellään käytettävät muuttujat
            int mysteeri;
            int arvaus;
            Random rnd = new Random();                  //Tämä muuttuja on random tietotyyppiä, eli kone arpoo sen ohjelman alussa.

            List<int> integerLista = new List<int>();   //Perustetaan integertyypin lista nimeltä "integerLista"

            mysteeri = rnd.Next(1, 100);    //random sijoitetaan ja kerrotaan ohjelmalle, että arvottavan luvun on oltava väliltä 1-100.
            Console.WriteLine("**ARVAUSPELI** Ohjelma arpoi juuri luvun väliltä 1-100");
            Console.WriteLine("Saat yrittää arvata numeron");

            while (ok == false)             //While silmukka toteuttaa arvauksen toiston kunnes arvoitus ratkeaa, eli ok = true.
            {
                Console.WriteLine("Syötä arvaus ja paina enter");
                arvaus = int.Parse(Console.ReadLine());         //Arvaus luetaan konsolilta.
                integerLista.Add(arvaus);                      //Arvaus talletetaan integerLista :lle.

                if (arvaus < mysteeri)            //Verrataan arvausta koneen alussa arpomaan mysteerilukuun IF lausella.
                {
                    Console.WriteLine("Luku on suurempi kuin arvaus!");
                    ok = false;
                }
                else if (arvaus > mysteeri)
                {
                    Console.WriteLine("Luku on pienempi kuin arvaus!");
                    ok = false;
                }
                else
                {
                    Console.WriteLine("***Arvasit oikein!*** käytit " + integerLista.Count + " arvausta");
                    ok = true;

                    Console.WriteLine("Seuraavaksi näet kaikki antamasi vastaukset järjestyksessään");

                    integerLista.Sort();                                    //Lista lajitellaan

                    for (int i = 0; i < integerLista.Count; i++)            //Listalta tulostetaan kaikki alkiot konsolille
                    {
                        Console.WriteLine(i + ". arvauksesi oli: " + integerLista[i]);
                    }

                    Console.Write("Paina enter lopettaaksesi pelin");
                    Console.ReadLine();

                }
            }
        }
    }
}
