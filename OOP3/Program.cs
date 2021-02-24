using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FilebaseLoggerService();
            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new DatebaseLoggerService(), new FilebaseLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
