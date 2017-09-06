using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class losowanie
    {
        public int zakres(int min, int max)
        {
            Random liczby = new Random();
           
            int num1 = liczby.Next(0, 1000);
            int num2 = liczby.Next(0, 1000);
            Console.WriteLine($"First random number: {num1}. Second random number: {num2}");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            Console.WriteLine();
            Console.Read();
        }
    }
}