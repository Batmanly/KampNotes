using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // Do Not  repeat yourself -- Kendini Tekrar etme(DRY) -- Clean Code -- Best Practice(Dogru uygulama Teknikleri)
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";


            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 }; // class-Array

            //type-safe -- tip guvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
                
            }

            Console.WriteLine("---------Metotlars-----------");
            // instance  - ornek
            // Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil", 12,9);
            sepetManager.Ekle2("Armut", "Kirmizi", 12,20);



        }
    }
}

