using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Stack               //Heap 
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "ilker";
            //// isimler = new string[5];  Array size is 5
            //isimler = new string[5];

            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };//Generic List Collection
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker2");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
