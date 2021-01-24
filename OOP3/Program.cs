using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // we can use IkrediManager >> interface instead of IhtiyacKrediManager and others
            // it will take reference this classes 
            // interfaceler referans tutucu olarak kullanilir

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
            // basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            // basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };
            basvuruManager.BasvuruYap(konutKrediManager, loggers);
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            // we cant make new at the interfaces
            // it will work which we send >> on the screen
            // basvuruManager.BasvuruYap(ihtiyacKrediManager);
            // basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
            basvuruManager.KredoOnBilgilendirmesiYap(krediler);

        }
    }
}
