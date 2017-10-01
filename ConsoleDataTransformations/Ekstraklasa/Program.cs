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
            using (IDbConnection db = new EkstraklasaContext())
            {
                dbContext.Treners.Add(new Trener()
                {
                    Imie = "l",
                    Nazwisko = "d",
                    Data_urodzenia = DataTime.Now,
                }
                );
               // var fromUserNazwisko = "Nowak";
                //var trener = db.Query<Trener>
                //("SELECT * FROM Ekstraklasa.dbo.Trener WHERE Nazwisko=" + fromUserNazwisko + "'").ToList();
                //Console.WriteLine(trener.First().Nazwisko);
            }            Console.ReadLine();
        }
    }
}
