using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Создать класс Игра с событиями Атака и Лечить. В main создать
некоторое количество игровых объектов. Подпишите объекты на
события произвольным образом. Реакция на события у разных
объектов может быть разной (без изменения,
увеличивается/уменьшается уровень жизни). Проверить состояния
игровых объектов после наступления событий, возможно не
однократном.
 */
namespace Delegates_Q1
{
    public delegate void Action(int points);
    static class Game
    {
        public static event Action damage;
        public static event Action heal;
        public static Action ShowDmgEvent = (points) => 
        {
            Console.WriteLine("Object was attacked");
            damage?.Invoke(points);
        };
        public static Action ShowHealEvent = (points) =>
        {
            Console.WriteLine("Object was healed");
            heal?.Invoke(points);
        };
    }
    class Unit
    {
        public string Name { get; set; }
        public int Hp { get; set; } 
        public void HpIncrease(int points)
        {
            Hp += points;
        }
        public void HpDecrease(int points)
        {
            Hp -= points;
        }
        public Unit(string name,int hp)
        {
            Hp = hp;
            Name = name;
            Console.WriteLine("Entered new unit: "+this);
        }
        public override string ToString()
        {
            return $"Name: {Name} Hp: {Hp}";
        }
    }
}
