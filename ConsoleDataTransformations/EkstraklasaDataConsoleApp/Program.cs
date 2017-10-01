using EkstraklasaDataConsoleApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaDataConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EkstraklasaContext())
            {
                dbContext.Trener.Add(new Trener()
                {
                    Imie = "Adi",
                    Nazwisko = "Stan",
                    Data_urodzenia = DateTime.Now
                });
                dbContext.SaveChanges();
                dbContext.Trener.ToList()[0].Imie = "NADAJE CI NOWE IMIE";
                dbContext.SaveChanges();
                dbContext.Trener.ToList()[0].Nazwisko = "NADAJE CI NOWE nazwisko";
                dbContext.SaveChanges();

                var trener = dbContext.Trener.Last("DELATE FROM [Ekstraklasa].[dbo].[Trener] WHERE ID=19" );
                dbContext.Trener.Remove(trener);
                dbContext.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
