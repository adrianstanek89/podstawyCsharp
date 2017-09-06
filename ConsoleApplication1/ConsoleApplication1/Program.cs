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
            int check = 0;

            int[] tablica = new int[1000];

            Random rand = new Random();
            for (int i = 0; i < tablica.Length;)
            {
                check = rand.Next(0, 1000);
                Console.WriteLine("" + check);
                    tablica[i] = check;
                    i++;
            }

            Console.ReadKey();


        }
    }
}


