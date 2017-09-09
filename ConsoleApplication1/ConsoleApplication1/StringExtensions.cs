using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class StringExtensions
    {
        public static List<string> blacklist = new List<string>() { "chuj", "dupa", "cycki" };
        public static bool IsBad(this string word)
        {
            if (blacklist.Contains(word))
            {
                return true;
            }
            return false;
        }
    }
}
