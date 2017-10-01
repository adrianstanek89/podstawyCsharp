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
            foreach (var product in dbContext.Product)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Color: {2}", product.ProductID, product.Name, product.Color);
            }
        }
    }
}
