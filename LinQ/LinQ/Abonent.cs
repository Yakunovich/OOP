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
    class Abonent
    {
        public string Surname { get; set; }
        public int Time { get; set; }
        public bool UsedM { get; set; }
        public int Debet { get; set; }
        public Abonent(string surname,int time,bool usedm,int debet)
        {
            Surname = surname;
            Time = time;
            UsedM = usedm;
            Debet = debet;
        }       
        public override string ToString()
        {
            return $"Name: {Surname} Time: {Time} Use Междугороднюю связь: {UsedM} Debet: {Debet}";
        }
    }
}
