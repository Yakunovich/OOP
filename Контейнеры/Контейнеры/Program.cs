using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Контейнеры;

//Продукт, Кондитерское изделие, Товар, Цветы, Торт,
//Часы, Конфеты;
//Собрать Подарок.Рассчитать цену подарка.
//Найти в подарке компонент с наименьшей массой.
//Произвести сортировку компонентов по габаритам.
namespace Наследование
{   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product p = new Product("Gosu", -3, "OPENAI", 10);
            }
            catch(ProductException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nInvalid value: {ex.Value}");
            }

            //Gift gift=new Gift(5);
            //Cake cake = new Cake(180, 10, "Напалеон", "Brest Con",2500);

            ////((Igoods)cake).CanWeEatIt();


            //Clock clock = new Clock(80, "G-shock", "Casio",10);
            //Console.WriteLine(clock.ToString());
            //Product product = clock as Product;
            ////product.CanWeEatIt();
            //Printer printer = new Printer();
            ////Flowers flowers = new Flowers("Brest Flow", 20, "Rose");
            ////Sweets sweets = new Sweets(356, 10, "Orange", "Roshen");
            //Product product1 = cake as Product;
            //Product prod = new Product("HZ", 100, "Fics",0);

            //gift.Add(prod);
            //gift.Add(product);
            //gift.Add(product1);
            //gift.Output();
            //gift.Sort();
            //gift.Output();
            ////gift.Sort();
            ////Controller controller = new Controller();
            ////controller.Cost(gift.GetList());
            ////controller.Sort(gift.GetList());
            ////gift.Output();

            ////Product[] arr = new[] { product, product1 };
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    printer.ImAmPrinting(arr[i]);
            ////}
            //////Console.WriteLine( cake.ToString());
            //////Confectionery confectionery = cake as Confectionery;
            //////Console.WriteLine(confectionery.ToString()); 
            //////Gift.Add(product);


        }

    }
    
}
