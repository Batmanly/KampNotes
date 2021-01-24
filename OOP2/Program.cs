using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "134123432432";
            musteri1.Id = 2;

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "32423";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "21323231212";

            //Gercek Musteri - Tuzel Musteri
            //SOLID >> 

            //new == new referance at memory
            //Musteri can take referance GercekMusteri and TuzelMusteri  >> because he is father of them :)
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            //interfaceleri birbirinin alternativi olan ama kod tutucu olarak kullaniriz

        }
    }
}
