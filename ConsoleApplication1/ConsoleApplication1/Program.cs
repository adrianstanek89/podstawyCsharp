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
            Console.Write("Podaj pierwsza liczbe: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj druga liczbe :");
            b = int.Parse(Console.ReadLine());
            wynik = a + b;
            Console.WriteLine("Wynik: " + wynik);
            Console.ReadLine();
        }
    }
}
