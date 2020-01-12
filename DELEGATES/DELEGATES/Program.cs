using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс Игра с событиями Атака и Лечить.В main создать
//некоторое количество игровых объектов. Подпишите объекты на
//события произвольным образом. Реакция на события у разных
//объектов может быть разной (без изменения,
//увеличивается/уменьшается уровень жизни). Проверить состояния
//игровых объектов после наступления событий, возможно не
//однократном.

namespace DELEGATES
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A simple string !";
            //char symb = '!';
            Func<string,char,string> retF = AddSymb;
            //str=Operation(str, symb,retF);
            retF += RemoveSymb;
            //str = Operation(str, symb, retF);
            retF += DownSymb;
            retF += UpSymb;
           // str = Operation(str, 's',retF);
            
            str = Operation(str, 'A', retF);
           // Func<string,char,string>ret = AddDot;
            //str = Operation(str,retD);

        }
        //static string Operation(string str, Func<string, string> retD)
        //{
        //    if (str != null)
        //        str = retD(str);
        //    Console.WriteLine(str);
        //    return str;
        //}
        static string Operation(string str,char symb, Func<string, char, string> retF)
        {
            if (str != null)
                str=retF(str, symb);
            return str;
        }
      

        public static string RemoveSymb(string a, char symb)
        {
            while (a.IndexOf(symb) >= 0)
                a=a.Remove(a.IndexOf(symb), 1);
            Console.WriteLine($"Symbol {symb} has been removed");
            Console.WriteLine(a);
            return a;
        }
        
        public static string AddSymb(string a, char symb)
        {
            a = a + symb;            
            Console.WriteLine($"Symbol {symb} has been added");
            Console.WriteLine(a);
            return a;
        }
        public static string UpSymb(string a, char symb)
        {
            a=a.Replace(symb, a.Substring(a.IndexOf(symb)).ToUpper()[0]);
            Console.WriteLine($"Symbol {symb} has been upped");
            Console.WriteLine(a);
            return a;
        }
        public static string DownSymb(string a, char symb)
        {
            a=a.Replace(symb, a.Substring(a.IndexOf(symb)).ToLower()[0]);
            Console.WriteLine($"Symbol {symb} has been downed");
            Console.WriteLine(a);
            return a;
        }
        public static string AddDot(string a,char dot)
        {
            Console.WriteLine("Dot has been added to this string");
            Console.WriteLine(a);
            return a + '.';
        }
    }
}
