using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dodawanie
    {
        public void AddRandomNumbers(int min, int max)
        {
            Random random = new Random();
            int num1 = random.Next(min, max);
            int num2 = random.Next(min, max);
            Console.WriteLine($"First random number: {num1}. Second random number: {num2}");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static decimal AddRandomNumbers(decimal liczba1, decimal )
}
