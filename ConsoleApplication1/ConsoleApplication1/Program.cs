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

            int sum = 0;

            for (int i = 0; i < 50; i++)
            {
                int liczba = liczby.Next(0, 1000);
                sum += liczba;
                Console.WriteLine("----> {0}", liczba);
            }

            Console.WriteLine("suma: {0}", sum); Console.Read();
            Console.Clear();
            goto poczatek;
        }
    }
}
