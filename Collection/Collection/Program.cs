using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание номер 1
            Random rand = new Random();
            //var Student = new { name = "Alex", surname = "Yakunovich " };
            //ArrayList array = new ArrayList();
            //array.Add("Vanya Denisyuk i Samaren Nekita");
            ////array.OutPut();
            //array.Add(Student);
            ////array.OutPut();
            //array.Remove(Student);
            ////array.OutPut();
            //Console.WriteLine(array.Capacity);
            //Console.WriteLine(array.IndexOf("Vanya Denisyuk i Samaren Nekita"));
            //Задание номер 2
            //Dictionary<int, double> dictionary = new Dictionary<int, double>();
            //Stack<double> stack = new Stack<double>();
            //for (int i = 0; i < 10; i++)
            //{
            //    dictionary.Add(i, Convert.ToDouble(rand.Next(1000)) / 100);
            //}
            //foreach (KeyValuePair<int, double> a in dictionary)
            //{
            //    Console.WriteLine(a);
            //    stack.Push(a.Value);
            //}
            //Console.WriteLine("Enter double value");
            //double val = Convert.ToDouble(Console.ReadLine());

            //for (int j = 0; stack != null; j++)
            //{

            //    if (val == stack.Pop())
            //    {
            //        Console.WriteLine("Index of this element was {0}", j);
            //        break;
            //    }
            //}
            //Задание 3
            Product product1 = new Product("G-shock 800", 200, "Casio");
            Product product2 = new Product("B-shock 800", 120, "Casio");
            Product product3 = new Product("A-shock 800", 300, "Casio");
            Product product4 = new Product("O-shock 800", 300, "Casio");
            Product product5 = new Product("Audi 100", 2300, "Audi");
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("________________________________________");
            products.RemoveRange(1, 2);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("________________________________________");
            products.Add(product5);
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("________________________________________");
            SortedSet<Product> products2 = new SortedSet<Product>();
            foreach (Product product in products)
            {
                products2.Add(product);
            }
            foreach (Product product in products2)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("________________________________________");

            //ObservableCollection<Product> products = new ObservableCollection<Product>();
            //Product product1 = new Product("G-shock 800", 200, "Casio");
            //Product product2 = new Product("B-shock 800", 120, "Casio");
            //Product product3 = new Product("A-shock 800", 300, "Casio");
            //Product product4 = new Product("O-shock 800", 300, "Casio");

            //products.CollectionChanged += Product_CollectionChanged;

            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);
            //products.Add(product4);
            //products.RemoveAt(1);
            //products[0] = product2;

            //foreach (Product user in products)
            //{
            //    Console.WriteLine(user.Name);
            //}

            //Console.Read();
        }

        private static void Product_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Product newUser = e.NewItems[0] as Product;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Product oldUser = e.OldItems[0] as Product;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Product replacedUser = e.OldItems[0] as Product;
                    Product replacingUser = e.NewItems[0] as Product;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
    }
}
