using ConsoleDataTransformations.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDataTransformations
{
    class Program
    {
        static void Main(string[] args)

        {

            AWDataContext dbContext = new AWDataContext();
            //foreach (var product in dbContext.Product)
            //{
            //    Console.WriteLine("Id: {0}, Name: {1}, Color: {2}", product.ProductID, product.Name, product.Color);
            //}
            foreach (var order in dbContext.SalesOrderHeader)
            {
                Console.WriteLine("SalesHeaderID: {0}, OrderDate: {1}, Status: {2}, TotalDue: {3}", order.SalesOrderID, order.OrderDate, order.Status, order.TotalDue);
            }
        }
    }
}
