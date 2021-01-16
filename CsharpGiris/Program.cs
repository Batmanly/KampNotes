using System;

namespace CsharpGiris
{
    class Program
    {
        static void Main(string[] args)//Main icindeikler calismaya baslar ilk basta
        {
            //string deger tutar char dizisi
            //type safety - tip guvenli (c# ve java katidir)
            //Do not repeat yourself - Kendini Tekrarlama (Clean code rule)
            //deger tutucu alias
            string kategoeriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.34;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kullanici Ayaralari");

            }
            else if (true)
            {

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoeriEtiketi);


        }
    }
}
