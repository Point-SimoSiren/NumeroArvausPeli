using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean ok = false;
            int mysteeri;
            int arvaus;
            Random rnd = new Random();  //Otetaan käyttöön Random toiminnallisuus ja asetetaan se rnd muuttujaan.

            //Perustetaan integertyypin lista nimeltä "integerLista"
            List<int> integerLista = new List<int>();   

            //Random arvotaan sijoitetaan mysteeri muuttujaan ja kerrotaan ohjelmalle, että arvottavan luvun on oltava väliltä 1-100.
            mysteeri = rnd.Next(1, 100);
            
            Console.WriteLine("**ARVAUSPELI** Ohjelma arpoi juuri luvun väliltä 1-100");
            Console.WriteLine("Saat yrittää arvata numeron");

            while (ok == false)  //While silmukka toteuttaa arvauksen toiston kunnes arvoitus ratkeaa, eli ok = true.
            {
                Console.WriteLine("Syötä arvaus ja paina enter");
                arvaus = int.Parse(Console.ReadLine());  //Arvaus luetaan konsolilta.
                integerLista.Add(arvaus);   //Arvaus talletetaan integerLista :lle.

                //Verrataan arvausta koneen alussa arpomaan mysteerilukuun IF lausella.
                if (arvaus < mysteeri)            
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

                    integerLista.Sort();    //Lista lajitellaan

                    for (int i = 0; i < integerLista.Count; i++)  //Listalta tulostetaan kaikki alkiot konsolille
                    {
                        Console.WriteLine("Funtsi tämä kohta itse!"); // integerLista[0] avulla pääsisit tulostamaan 1. arvauksen moneen kertaan, mutta mitä laitat 0 tilalle nyt? 
                    }

                    Console.Write("Paina enter lopettaaksesi pelin");
                    Console.ReadLine();

                }
            }
        }
    }
}
