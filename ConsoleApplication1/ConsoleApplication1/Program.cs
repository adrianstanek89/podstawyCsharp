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
            int a, b;
            Console.Write("Podaj wartosc min: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj wartosc max: ");
             b = int.Parse(Console.ReadLine());
            int check = 0;

            int[] tablica = new int[5];

            Random rand = new Random();
            for (int i = 0; i < tablica.Length;)
            {
                check = rand.Next(a, b);
                Console.WriteLine("liczba: " + check);
                tablica[i] = check;
                i++;
            }

            Console.ReadKey();


        }
    }
}


