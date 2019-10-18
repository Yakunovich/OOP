using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Наследование;


namespace Контейнеры
{

    class Gift
    {

        List<Product> MyList = new List<Product>();
        private int size;
        static int count = 0;
        public List<Product> GetList()
        {
            return MyList;
        }
        public Gift(int i)
        {
            Size = i;
        }
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public void Add(Product a)
        {
            if (count == size) Console.WriteLine("Не хватает места");
            else
            {
                MyList.Add(a);
                count++;
            }
        }
        public void Delete(Product product)
        {
            MyList.Remove(product);
            count--;
        }
        public void Output()
        {
            int i = 0;
            foreach (object a in MyList)
            {
                i++;
                Console.WriteLine($"{i} element : {a.ToString()}");
            }
        }
        public void Sort()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Sorted List :");
            MyList.Sort1();

        }
        public void TotalCost()
        {
            Console.WriteLine("**********************************************************************************************");
            MyList.Cost();
        }

    }
    static class Controller
    {

        private static int cost;
        public static void Cost(this List<Product> products)
        {
            foreach (Product a in products)
            {
                cost += a.Price;
            }
            Console.WriteLine($"Total cost : {cost}");
        }
        public static List<Product> Sort1(this List<Product> products)
        {
            var SortedProducts = from a in products orderby a.Price select a;
            int i = 0;
            foreach (Product a in SortedProducts)
            {
                if (i < products.Capacity) products[i] = a;
                else break;
                i++;
            }
            return products;
        }
    }
}
