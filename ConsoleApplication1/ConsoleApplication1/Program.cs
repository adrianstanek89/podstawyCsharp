using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        poczatek:
            Random liczby = new Random();
            int[] all = new int[4];
          

            for (int i = 0; i < all.Length;)
            {
                int liczba = liczby.Next(0, 25);
                Console.WriteLine("Random number to be checked is -> " + liczba);
                Console.Read();
            }
                int suma = 0;

            Console.WriteLine(all);
            for (int i = 0; i < 50; i++)
            {
                int liczba = liczby.Next(0, 1000);
                suma += liczba;
                Console.WriteLine("kolejna liczba => {0}", liczba);
            }

            Console.WriteLine("suma liczb: {0}", suma); Console.Read();
            Console.Clear();
            goto poczatek;
        }
    }
}
