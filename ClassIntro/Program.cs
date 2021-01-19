using System;

namespace ClassIntro
{

    class Kurs
    {
        //prop >> properties
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            //we set our kurs1 properties
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 20000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "fdsafasd";
            kurs2.IzlenmeOrani = 20000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Temel";
            kurs3.IzlenmeOrani = 20000;


            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 }; // Kurs Array
            foreach (var kurs_in in kurslar)
            {
                Console.WriteLine(kurs_in.Egitmen + " " + kurs_in.KursAdi + " " + kurs_in.IzlenmeOrani);

            }
            Console.WriteLine();
        }
    }
}
