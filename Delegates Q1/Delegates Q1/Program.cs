using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Q1
{
    class Program
    {
        //delegate void ClientInfo(Client client);
        //delegate Person PersonFactory(string name);
        static void Main(string[] args)
        {
            //ClientInfo clientInfo = GetPersonInfo; // контравариантность
            //Client client = new Client { Name = "Alice" };
            //clientInfo(client);
            //Console.Read();
            //////PersonFactory personDel;
            //////personDel = BuildClient; // ковариантность
            //////Person p = personDel("Tom");
            //////Console.WriteLine(p.Name);
            //////Console.Read();
            Unit knight = new Unit("Sven",150);
            var priest = new Unit("Anduin",65);
            Game.damage += knight.HpDecrease;
            Game.damage += priest.HpDecrease;
            Game.heal += priest.HpIncrease;
            Game.heal += knight.HpIncrease;
            Game.ShowDmgEvent(20);
            Console.WriteLine(knight);
            Game.ShowHealEvent(10);
            Console.WriteLine(knight);
        }
    }
    //private static Client BuildClient(string name)
    //{
    //    return new Client { Name = name };
    //}
    //private static void GetPersonInfo(Person p)
    //{
    //    Console.WriteLine(p.Name);
    //}
}
