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
            short a, b;
            Console.Write("Podaj wartosc min w przedziale od 0 do 9 : ");
            a = short.Parse(Console.ReadLine());
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
                    a = short.Parse(Console.ReadLine());

                }
                else if (0 <= a && a < 10)
                {
                    goto one;
                }
            }
            while (true);
            one:
            Console.Write("Podaj wartosc w przedziale 9-99: ");
            b = short.Parse(Console.ReadLine());
            do
            {
                if (10 > b || 99 < b)
                {
                    Console.WriteLine("Podałes zla wartosc :");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musi to byc liczba z przedziału 9-99");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Podaj wartosc w przedziale 9-99: ");
                    b = short.Parse(Console.ReadLine());
                }
                else if (10 <= b && b < 100)
                {
                    goto two;
                }
            }
            while (true);
            two:
            int Nparz = 0;
            int parz = 0;
            int zakres = 0;
            int[] tablica = new int[1000];
            Random liczby = new Random();
            for (int i = 0; i < tablica.Length;)
            {
                zakres = liczby.Next(a, b);
                // Console.WriteLine("cyfry: " + zakres);
                tablica[i] = zakres;
                i++;

            }
            int[] tablica2 = new int[50];
            Array.Copy(tablica, 0, tablica2, 0, 50);

            foreach (int element in tablica2)
            {
                // Console.WriteLine("liczba: "+ element); 
                if (element % 2 == 0)
                {

                    // Console.WriteLine("parzysta: "+ element); 
                    parz += element;
                   
                }
                if (element % 2 == 1)
                {

                    // Console.WriteLine("parzysta: "+ element); 
                    Nparz += element;

                }


            }
            Console.WriteLine("suma liczb parzystych: " + parz);
            Console.WriteLine("suma liczb nie parzystych: " + Nparz);
            Console.WriteLine("suma wszystkich liczb: " + (Nparz+parz));

            Console.ReadKey();
        }
    }
}