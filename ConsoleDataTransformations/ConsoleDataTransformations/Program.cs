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
                        Console.WriteLine(dataReader[0] + " | " + dataReader[1] + "|"  + dataReader[2]);
                    }
                    dataReader.Close();

                    // insert record


                    //var Name = "New Scrap Reason| " + DateTime.Now.ToShortTimeString();
                    //var CurrentTime = DateTime.Now;
                    //command.CommandText = string.Format(@"INSERT INTO [Production].[ScrapReason] ([Name] ,[ModifiedDate]) VALUES ('{0}','{1}')", Name, CurrentTime);
                    //var rowsAffected = command.ExecuteNonQuery();
                    //Console.WriteLine("Dodano {0} rekordów", rowsAffected);
                    string NameOne = "One One One ";

                    command.CommandText = string.Format(@"UPDATE [Production].[ScrapReason] SET [Name] ='{0}' WHERE  [Production].[ScrapReason].ScrapReasonID = 1 ", NameOne);
                    var rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Edytowano {0} rekordów", rowsAffected);

                    string NameTwo = "two Two two ";

                    command.CommandText = string.Format(@"UPDATE [Production].[ScrapReason] SET [Name] ='{0}' WHERE  [Production].[ScrapReason].ScrapReasonID = 2 ", NameTwo);
                    var rowsAffected2 = command.ExecuteNonQuery();
                    Console.WriteLine("Edytowano {0} rekordów", rowsAffected);


                    Console.WriteLine("Podaj ID wiersza, ktory chcesz usunac");
                    int IdToDelete = Int32.Parse(Console.ReadLine());
                    command.CommandText = string.Format(@"DELETE FROM [Production].[ScrapReason] WHERE [ScrapReasonID] = {0}", IdToDelete);
                    var rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Usunieto {0} rekordów", rowsAffected);
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
