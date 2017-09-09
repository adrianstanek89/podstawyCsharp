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
            string s = "czesto chuj  dupa cycki dasdas das ad asd testowe dane";
            foreach(var word in s.Split(" ").ToList())
            {
                if (word.IsBad())
                    continue;
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
