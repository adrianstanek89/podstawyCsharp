using ConsoleApplication1.EP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstraklasa
{
    class Program
    {
        private static object dbContext;

        public static object DataTime { get; private set; }

        static void Main(string[] args)
        {
            using (var dbContext = new EkstraklasaContext())
            {
                dbContext.Trener.Add(new Trener()
                {
                    Imie = "Twoje Imie",
                    Nazwisko = "Twoje Nazwisko",
                    Data_urodzenia = DateTime.Now
                });
            }
            Console.ReadLine();
            // var fromUserNazwisko = "Nowak";
            //var trener = db.Query<Trener>
            //("SELECT * FROM Ekstraklasa.dbo.Trener WHERE Nazwisko=" + fromUserNazwisko + "'").ToList();
            //Console.WriteLine(trener.First().Nazwisko);
       
        }
    }
}
