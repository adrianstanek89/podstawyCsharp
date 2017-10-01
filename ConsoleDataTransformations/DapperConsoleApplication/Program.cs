using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsoleApplication
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {
            using (IDbConnection db = new SqlConnection(@"data source =.; initial catalog = AdventureWorks2012; integrated security = True;"))
            {
                var scrapReasonList = db.Query<Product>
                ("Select products From Production.Product").ToList();
                scrapReasonList.ForEach(sr =>
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Color: {2} ", product.ProductID, product.Name, product.Color);
          });
            }
            Console.ReadLine();
        }
    }
}
