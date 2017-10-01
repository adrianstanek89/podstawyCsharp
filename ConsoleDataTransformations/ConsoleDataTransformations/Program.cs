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
            using (SqlConnection connection = new SqlConnection(@"data source=RENT-KOMPUTER;initial catalog=AdventureWorks2012;integrated security=SSPI"))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT [Name], [ProductNumber], [Color] FROM[Production].[Product]";
                SqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader[0] + " | " + dataReader[1] + "|"
                       + dataReader[2]);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            Console.ReadLine();
        }
    }
}
