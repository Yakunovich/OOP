using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//сведения об абонентах, у которых время внутригородских
//разговоров превышает заданное;
//сведения об абонентах, которые пользовались междугородной
//связью;
//количество абонентов с заданным значением дебета
//максимального абонента(по вашему критерию)
//упорядоченный список абонентов по фамилии

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time");
            int Time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter debet");
            int Debet = Convert.ToInt32(Console.ReadLine());

            List <Abonent> ausingm= new List<Abonent>();
            
            
            List<Abonent> abonents = new List<Abonent>();
            Abonent Pashtet = new Abonent("Pashtet", 1301, true, 0);
            Abonent Max = new Abonent("Maxim", 200, true, 352);
            Abonent Alexey = new Abonent("Alexey", 220, false, 120);
            Abonent Alexandr = new Abonent("Alexandr", 120, true, 320); ;
            Abonent Ivan = new Abonent("Ivan", 250, false, 320);
            Abonent Egor = new Abonent("Egor", 520, false, 320);
            Abonent Sem = new Abonent("Sem", 900, true, 3123);
            ausingm.Add(Max);
            ausingm.Add(Pashtet);
            ausingm.Add(Alexandr);
            ausingm.Add(Sem);
            abonents.Add(Max);
            abonents.Add(Alexandr);
            abonents.Add(Alexey);
            abonents.Add(Ivan);
            abonents.Add(Egor);
            abonents.Add(Sem);
            var abonentssort = abonents.OrderBy(s=>s.Surname).Select(s=>s);
            //var abonentssort = abonents.Where(s=>s.UsedM==true);
            //Console.WriteLine(abonents.Max(s=>s.Debet));
            var maxab = from a in abonents where a.Debet == abonents.Max(s => s.Debet) select a;
            foreach (var a in maxab)
            {
                Console.WriteLine(a);
            }
            //var abonentssort = abonents.Where(s=>s.Time>Time);
            //var abonentssort = abonents.Where(s=>s.Debet==Debet);
            // var abonentssort = abonents.OrderBy(s=>s.Surname).ThenBy(s=>s.Time).Where(s=>s.Debet==Debet).Where(s=>s.Time>Time).Select(s=>s);
            /* var abonentssort = from ab in abonents
                          join ab2 in ausingm on ab.UsedM equals ab2.UsedM
                          select ab;*/
            foreach (Abonent i in abonentssort)
            {
                Console.WriteLine(i);
            }

        }
    }
}
