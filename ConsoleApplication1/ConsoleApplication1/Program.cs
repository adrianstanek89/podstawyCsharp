using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Months));
            foreach (var month in values)
            {
                Console.WriteLine(month);
            }

            Console.ReadKey();
        }
    }
}
