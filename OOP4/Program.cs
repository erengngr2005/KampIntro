using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();    
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService databaseLogerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLogerService);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
