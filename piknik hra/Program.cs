﻿using System;
using System.Collections.Generic;

namespace piknik_hra
{
    class Program
    {


        /*tu MATEJ naplni vsetky tri listy (lahky, stredny, tazky) slovami
         * kluce budu static a budu sa volat nasledovne
         * (k listu lahky bude kluc lahkyKluc)
         * 
         * ten kluc moze byt v poriadku ako string a nie ako pole charov kedze mi ho v programe
         * vobec nevyuzijeme a ani nepotrebujeme, sluzi len pre toho co to hra
         * aby vedel z coho ma skladat
         */
        static List<string> lahky = new List<string>();


        static string lahkyKluc = String.Empty;



        static List<string> stredny = new List<string>();

        static string strednyKluc = String.Empty;



        static List<string> tazky = new List<string>();

        static string tazkyKluc = String.Empty;



        static void Main(string[] args)
        {

            /*v maine RICHARD spravi to ze ked  typek pride do programu
             * tak zada svoje meno. Potom dostane 4 moznosti: koniec, alebo jednu z troch obtiaznosti.
             * moznosti bude dostavat zakazdym ked sa skonci jedna moznost. 
             * pre pochopenie: vyberie moznost lahke, typek bude hrat atd atd a ked skonci 
             * je jedno ci vyhra alebo prehra dostane na vyber ci chce pokracovat alebo
             * skoncit. 
             */

            //naplnenie listu
            lahky.Add("na");
            lahky.Add("než");
            lahky.Add("neha");
            lahky.Add("anežka");
            lahky.Add("žena");

            lahkyKluc = "n e a ž k a";


            //zacanie mainu
            Console.WriteLine("zadaj svoje meno");
            string pouzivatel = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("zadaj obtiaznost (L-lahka, S-stredna, T-tazka, K-koniec)");
                string vyberPouzivatela = Console.ReadLine();

                if (vyberPouzivatela == "L")
                {
                    int pocetZlych = 0;
                    int pocetUhadnutych = 5;
                    Console.WriteLine("skladaj podla tyhto slov: " + lahkyKluc);

                    for (int i = 0; i < 5; i++)
                    { 
                        
                        string input = Console.ReadLine();

                        if (porovnanieInputS(input, lahky) == true)
                        {
                             pocetUhadnutych--;
                             Console.WriteLine("zostavajuci pocet slov: " + pocetUhadnutych);
                        }
                        else 
                        {
                            Console.WriteLine("zadal si zle");
                            pocetZlych++;

                            if (pocetZlych > 2)
                            {
                                break;
                            }
                        }
                        

                    }
                    

                }
            }




        }

        //funkcia na testovanie ci je input totozny s hladanym slovom
        static bool porovnanieInputS(string input, List<string> ks)
        {
            bool aa = false;
            for (int i = 0; i < ks.Count; i++)
            {
                if (input == ks[i])
                {
                    aa = true;
                }
            }
            return aa;
        }







        //funkcia na volne riadky
        static void volneRiadky(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(" ");
            }
        }


    }
}
