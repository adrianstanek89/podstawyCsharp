using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static class StringExtensions
        {
            public static List<int> blackListNumber = new List<int>() ;
            public static bool IsBadNumber(this string number, IEnumerable<int> blackListNumber);
           

                private static void Randomer()
            {
                Random rand = new Random();
                for(int i=0; i < 50; i++)
                {
                    blackListNumber.Add(rand.Next(0, 100));
                }
            }
            {
                if (blacklistNumber.Contains(number))
                {
                    return true;
                }
                return false;
            }
        }
    }
    }
}
