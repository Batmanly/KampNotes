using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Basvuran bilgileri degerlendirme
            //
            //hangi referansi yollarsak ona gore hesaplama yapar
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //loggerService.Log(); // hangi loglayici secilmis ise onu loglar

        }

        //burda birden fazla kredi hesabi yaptirmak icin liste collectionda tutuyoruz,turu IkrediManager
        public void KredoOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();//Listeki her bir kredi uzerinde bu operasyonu gerceklesitirecek
            }
        }
    }
}
