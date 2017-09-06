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
            int a = liczby.Next(0, 1000);
            
            Console.WriteLine();
            Console.Read();
        }
    }
}