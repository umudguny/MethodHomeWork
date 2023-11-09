using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() });


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); 


        }
    }
}
