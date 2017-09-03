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
            int a, b, wynik;
            Console.Write("Podaj pierwsza liczbe mniejsza od 100: ");
            a = int.Parse(Console.ReadLine());
            if (a < 100)
            {
                Console.Write("Podaj druga liczbe :");
                b = int.Parse(Console.ReadLine());
                wynik = a + b;
                Console.WriteLine("Wynik sumy dwuch liczb to : " + wynik);
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("podales zła liczb ");
                Console.ReadLine()sas;     
                          
            }
        }
    }
}
