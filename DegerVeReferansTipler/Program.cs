﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi 1 == 10
            //sayi 2 == 20

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            // stack >> deger tip tutar
            // heap >> referans tip tutar c ceki pointerar


            Console.WriteLine("Hello World!");
        }
    }
}
