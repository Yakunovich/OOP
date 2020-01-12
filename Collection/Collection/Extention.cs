using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    static class Extention
    {
        public static void OutPut(this ArrayList arrayList)
        {
            Console.WriteLine("List contains : ");
            foreach (var obj in arrayList)
            {
                
                Console.WriteLine(obj);
                
            }
            Console.WriteLine("______________________________________________________________");
        }
    }
}
