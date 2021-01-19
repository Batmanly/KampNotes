using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kurs1 = " Yazilim gelistirici yetistirme kampi";
            string kurs2 = " Porgramlama balsnagic icin temel kurs";
            string kurs3 = "java";

            string[] kurslar = new string[] { kurs1, kurs2, kurs3 };

            

            for (int x  = 0; x < kurslar.Length; x++)
            {
                Console.WriteLine(kurslar[x]);
            }

            foreach (var kurs in kurslar)
            {

                Console.WriteLine(kurs);
            }

           
        }

    }
}
