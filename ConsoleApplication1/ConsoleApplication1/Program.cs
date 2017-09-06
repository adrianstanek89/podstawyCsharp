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
            Console.Write("Podaj wartosc min w przedziale od 0 do 9 : ");
            a = int.Parse(Console.ReadLine());


            do
            {
                if (0 > a || 10 < a)
                {
                    Console.WriteLine("Podałes zla wartosc :");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musi to byc liczba z przedziału 0-9");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Podaj wartosc min w przedziale od 0 do 9 : ");
                    a = int.Parse(Console.ReadLine());
                 
                }
                else if (0 <= a && a < 10)
                {
                    goto one;
                }
            }
            while (true);

            one:

            Console.Write("Podaj wartosc w przedziale 9-99: ");
            b = int.Parse(Console.ReadLine());



            do
            {
                if (10 > b || 99 <b)
                {
                    Console.WriteLine("Podałes zla wartosc :");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musi to byc liczba z przedziału 9-99");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Podaj wartosc w przedziale 9-99: ");
                    b = int.Parse(Console.ReadLine());
                }
                else if (10 <= b && b < 100)
                {
                    goto two;
                }
            }
            while (true);

            two:

            int check = 0;

            int[] tablica = new int[1000];

            Random liczby = new Random();
            for (int i = 0; i < tablica.Length;)
            {
                check = liczby.Next(a, b);
                Console.WriteLine("liczba: " + check);
                tablica[i] = check;
                i++;
                int[] tablica2 = new int[50];

            }

            Console.ReadKey();


        }
    }
}


