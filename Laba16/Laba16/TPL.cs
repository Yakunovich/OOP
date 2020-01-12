using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Laba16
{
    partial class Program
    {
        public static async void AsyncEvenNum()
        {
            Console.WriteLine("Начало асинхронного метода");
            await Task.Run(() => EvenNum());
            Console.WriteLine("\nКонец асинхронного метода");
        }

        public static void EvenNum()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        public static void Supplier()
        {
            Random random = new Random();

            int x, z;
            List<string> products = new List<string>() { "Холодильник", "Плита", "Стиральная машина", "Пылесос", "Утюг" };
            for (int i = 0; i < 5; i++)
            {
                x = random.Next(0, products.Count - 1);
                BlockColl.Add(products[x]);
                Console.WriteLine($"Добавлен продукт - {products[x]}");
                products.RemoveAt(x);
                Thread.Sleep(random.Next(1, 3));
            }
            BlockColl.CompleteAdding();
        }

        public static void Consumer()
        {
            string str;
            while (!BlockColl.IsCompleted)
            {
                if (BlockColl.TryTake(out str))
                {
                    Console.WriteLine($"Был куплен товар - {str}");
                }
                else
                {
                    Console.WriteLine($"Покупатель ушел");
                }
            }
        }

        public static void Inv1()
        {
            Console.WriteLine("Inv1 запущен");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Inv1 =" + i);
            }
            Console.WriteLine("Inv1 завершен");
        }

        public static void Inv2()
        {
            Console.WriteLine("Inv2 запущен");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Inv2 =" + i);
            }
            Console.WriteLine("Inv2 завершен");
        }

        public static void task55(Task t)
        {
            Console.WriteLine("Continuation Task");
            Thread.Sleep(2000);
        }

        public static int task11(int i)
        {
            i *= 10;
            return i;
        }

        public static int task22(int i)
        {
            i += 9;
            return i;
        }

        public static int task33(int i)
        {
            i -= 8;
            return i;
        }

        public static void task4(int a, int b, int c)
        {
            int res;
            res = a + b + c;
            Console.WriteLine($"Результат: {res}");
        }

        public static void CreateMatrix(ref int[,] matrix1, ref int[,] matrix2, int row, int col)
        {
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = random.Next(0, 100);
                    matrix2[i, j] = random.Next(0, 100);
                }
            }

        }

        public static void Multiplication(int[,] matrix1, int[,] matrix2, ref int[,] matrix3)
        {
            Console.WriteLine($"\nID задачи - {task.Id}");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
                if (i == matrix1.GetLength(0) / 2)
                {
                    Console.WriteLine($"Статус задачи - {task.Status}; Статус завершения - {task.IsCompleted}");
                }
                if (i == matrix1.GetLength(0) / 5 && second_task)
                {
                    cancelTokenSource.Cancel();
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                }
            }
        }
    }
}
