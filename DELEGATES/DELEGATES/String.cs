using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    static class Edit
    {
        public static string RemoveSymb(this string a, char symb)
        {
            while (a.IndexOf(',') > 0)
                a = a.Remove(a.IndexOf(','), 1);
            Console.WriteLine($"Symbol {symb} has been removed");
            return a;
        }
        public static string AddSymb(this string a, char symb)
        {
            a = a + symb;
            Console.WriteLine($"Symbol {symb} has been added");
            return a;
        }
        public static string UpSymb(this string a, char symb)
        {
            a.Replace(symb, a.Substring(a.IndexOf(symb)).ToUpper()[1]);
            Console.WriteLine($"Symbol {symb} has been upped");
            return a;
        }
        public static string DownSymb(this string a, char symb)
        {
            a.Replace(symb, a.Substring(a.IndexOf(symb)).ToLower()[1]);
            Console.WriteLine($"Symbol {symb} has been downed");
            return a;
        }
        public static string AddDot(this string a)
        {
            Console.WriteLine("Dot has been added to this string");
            return a + '.';
        }
    }
}
