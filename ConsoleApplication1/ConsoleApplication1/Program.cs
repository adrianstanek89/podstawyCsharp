using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int NaszFor(int x, int y)
        {
            if (y < 0)
                return x;
            Console.WriteLine(x);
            y--;
            return NaszFor(x + 1, y);
        }

        static void Main(string[] args)
        {
            NaszFor(1, 10); 
        }
    }
}
