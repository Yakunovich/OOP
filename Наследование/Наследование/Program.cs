using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Продукт, Кондитерское изделие, Товар, Цветы, Торт,
//Часы, Конфеты;
namespace Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake cake = new Cake(180, 10, "Напалеон", "Brest Con");

            ((Igoods)cake).CanWeEatIt();
         
            
            Clock clock = new Clock(80, "G-shock", "Casio");
            Console.WriteLine(clock.ToString());
            Product product = clock as Product;
            product.CanWeEatIt();
            Printer printer = new Printer();
            Flowers flowers = new Flowers("Brest Flow",20,"Rose");
            Sweets sweets = new Sweets(356, 10, "Orange", "Roshen");
            Product product1 = cake as Product;
            Product[] arr = new[] { product, product1 };
            for (int i = 0; i < arr.Length; i++)
            {
                printer.ImAmPrinting(arr[i]);
            }
            //Console.WriteLine( cake.ToString());
            //Confectionery confectionery = cake as Confectionery;
            //Console.WriteLine(confectionery.ToString()); 
            printer.ImAmPrinting(clock);



        }
    }
    
    class Printer 
    {
        public  void ImAmPrinting(Product product)
        {
            Console.WriteLine(product.ToString());
        }
    }
    interface Igoods
    {
        void printInfo();
        void CanWeEatIt();
    }
    abstract class Product
    {
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Product(string manufacturer,int price,string name)
            {
            Manufacturer = manufacturer;
            Price = price;
            Name = name;
            }
        public virtual void CanWeEatIt()
        {
            Console.WriteLine("I don't know");
        }
        
    }
    class Confectionery: Product,Igoods
    {
        
        int Shelf_life { get; set; }
        public Confectionery(int shelf,int price,string name,string manufacturer):base(manufacturer,price,name)
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
        public override string ToString()
        {
            return Manufacturer+" "+Name+" "+Price+" ";
        }
    }
    sealed class Cake: Confectionery
    {
        
        
        public Cake(int shelf,int price, string name,string manufacturer) :base (shelf,price,name,manufacturer)
        {
            
        }
        public override string ToString()
        {
            return Manufacturer + " " + Name + " " + Price + " ";
        }
    }
    sealed class Sweets: Confectionery
    {
        public Sweets(int shelf, int price, string name, string manufacturer) :base (shelf, price, name, manufacturer)
        {
            
        }
        public override string ToString()
        {
            return Manufacturer + " " + Name + " " + Price + " ";
        }
    }
    sealed class Clock:Product,Igoods
    {
        public Clock(int price,string name,string manufacturer):base(manufacturer,price,name)
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
        public override string ToString()
        {
            return Manufacturer + " " + Name + " " + Price + " ";
        }
    }
    sealed class Flowers:Product,Igoods
    {
        public Flowers(string manufacturer,int price,string name):base(manufacturer,price,name)
        {

        }
        public void printInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nManufacturer{Manufacturer}");
        }
        public override string ToString()
        {
            return Manufacturer + " " + Name + " " + Price + " ";
        }

    }
}
