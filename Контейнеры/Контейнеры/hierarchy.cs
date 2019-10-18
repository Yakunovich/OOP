using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Наследование;

namespace Контейнеры
{
    abstract class Print
    {
        public virtual void ImAmPrinting(Product product)
        {
            Console.WriteLine(product.GetType() + " " + product.ToString());
        }
    }
    class Printer : Print
    {
        public override void ImAmPrinting(Product product)
        {
            base.ImAmPrinting(product);
        }
    }
    interface Igoods
    {
        void printInfo();
        void CanWeEatIt();
    }
    class Product
    {
        public string Manufacturer { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ProductException("Price cannot be less than 0 ", value);
                else price = value;
            }
        }
      
        public string Name { get; set; }
        public int Weight { get; set; }
        public Product(MyStruct _struct)
        {
            Manufacturer = _struct.manuf;
            Price = _struct.price;
            Name = _struct.name;
            Weight = _struct.weight;
        }
        public Product(string manufacturer, int price, string name, int weight)
        {
            Manufacturer = manufacturer;
            Price = price;
            Name = name;
            Weight = weight;
        }
        public virtual void CanWeEatIt()
        {
            Console.WriteLine("I don't know");
        }
        public override string ToString()
        {
            return Manufacturer + " " + Name + " " + Price;
        }

    }
    class Confectionery : Product, Igoods
    {

        int Shelf_life { get; set; }
        public Confectionery(int shelf, int price, string name, string manufacturer, int weight) : base(manufacturer, price, name, weight)
        {
            Shelf_life = shelf;

        }
        public void printInfo()
        {
            Console.WriteLine($"Price: {Price}$ \nName: {Name}\nShelf life: {Shelf_life}");
        }
        void Igoods.CanWeEatIt()
        {
            Console.WriteLine("Kanechna");
        }
        public override void CanWeEatIt()
        {
            Console.WriteLine("Ofc");
        }

    }
    sealed class Cake : Confectionery
    {


        public Cake(int shelf, int price, string name, string manufacturer, int weight) : base(shelf, price, name, manufacturer, weight)
        {

        }

    }
    sealed class Sweets : Confectionery
    {
        public Sweets(int shelf, int price, string name, string manufacturer, int weight) : base(shelf, price, name, manufacturer, weight)
        {

        }

    }
    sealed class Clock : Product, Igoods
    {
        public Clock(int price, string name, string manufacturer, int weight) : base(manufacturer, price, name, weight)
        {

        }
        public void printInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nManufacturer{Manufacturer}");
        }
        public override void CanWeEatIt()
        {
            Console.WriteLine("NOOOOOOOOOOO");
        }

    }
    sealed class Flowers : Product, Igoods
    {
        public Flowers(string manufacturer, int price, string name, int weight) : base(manufacturer, price, name, weight)
        {

        }
        public void printInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nManufacturer{Manufacturer}");
        }


    }
}
