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
        public static Task task;
        public static bool second_task = false;
        public static CancellationTokenSource cancelTokenSource;
        public static CancellationToken token;
        static BlockingCollection<string> BlockColl;


        static void Main(string[] args)
        {
            //Console.WriteLine("<--------------------> Задание 1 <-------------------->\n");
            int row = 1000, col = 1000;
            int[,] matrix1 = new int[row, col];
            int[,] matrix2 = new int[row, col];
            int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            //Console.WriteLine("Замеры генерации двух массивов 1000х1000");
            //Task[] tasks = new Task[3]
            //{
            //    new Task(() => Multiplication(matrix1, matrix2, ref matrix3)),
            //    new Task(() => Multiplication(matrix1, matrix2, ref matrix3)),
            //    new Task(() => Multiplication(matrix1, matrix2, ref matrix3))
            //};
            //for(int i=0;i<tasks.Length;i++)
            //{
            //    tasks[i].Start();
            //    Console.WriteLine($"Генерация {i + 1}\tСтатус задачи - {tasks[i].Status}мс\tВыполнена? {tasks[i].IsCompleted}");
            //}
            //Stopwatch stopWatch = new Stopwatch();
            //for (int i =0;i<10;i++)
            //{
            //    stopWatch.Restart();
            //    Program.CreateMatrix(ref matrix1, ref matrix2, row, col);
            //    stopWatch.Stop();
            //    Console.WriteLine($"Генерация {i + 1}\tВремя - {stopWatch.ElapsedMilliseconds}мс");

            //}           
            //Console.WriteLine("<--------------------> Задание 2 <-------------------->\n");
            //cancelTokenSource = new CancellationTokenSource();
            //token = cancelTokenSource.Token;
            //second_task = true;
            //task = new Task(() => Multiplication(matrix1, matrix2, ref matrix3));
            //task.Start();
            //task.Wait();

            //if (token.IsCancellationRequested)
            //{
            //    Console.WriteLine("Task отменен");
            //}
            //task.Dispose();
            //Console.WriteLine("<--------------------> Задание 3 <-------------------->\n");

            var task1 = Task.Factory.StartNew<int>(() => task11(10));
            var task2 = Task.Factory.StartNew<int>(() => task22(10));
            var task3 = Task.Factory.StartNew<int>(() => task33(10));
            task = new Task(() => task4(task1.Result, task2.Result, task3.Result));
            task.Start();
            task.Wait();
            task1.Dispose();
            task2.Dispose();
            task3.Dispose();

            //Console.WriteLine("<--------------------> Задание 4 <-------------------->\n");
            //Task task5 = new Task(()=> { Console.WriteLine($"ID: {Task.CurrentId}"); });
            //Task task6 = task5.ContinueWith(task55);
            //task5.Start();
            //task6.Wait();
            //task5.Dispose();
            //task6.Dispose();

            //var task7 = Task.Factory.StartNew<int>(() => task11(10));
            //task7.Wait();
            //var awaiter = task7.GetAwaiter();
            //if(awaiter.IsCompleted)
            //{
            //    Task task8 = new Task(() => { Console.WriteLine("GetAwaiter"); });
            //    task8.Start();
            //    task8.Wait();
            //    task8.Dispose();
            //}
            //task7.Dispose();
            //Console.WriteLine("<--------------------> Задание 5 <-------------------->\n");
            //int[] arr1 = new int[1000000];
            //int[] arr2 = new int[1000000];
            //Random random = new Random();

            //stopWatch.Restart();
            //for (int i =0;i<arr1.Length;i++)
            //{
            //    arr1[i] = random.Next(0, 200);
            //    arr2[i] = random.Next(0, 200);
            //}
            //stopWatch.Stop();
            //Console.WriteLine($"Генерация 2х массивов в for \tВремя - {stopWatch.ElapsedMilliseconds}мс");
            //int[] arr3 = new int[1000000];
            //int[] arr4 = new int[1000000];
            //stopWatch.Restart();
            //Parallel.For(0, arr3.Length, i => { arr3[i] = random.Next(0, 200); arr4[i] = random.Next(0, 200); });
            //stopWatch.Stop();
            //Console.WriteLine($"Генерация 2х массивов в ParallelFor \tВремя - {stopWatch.ElapsedMilliseconds}мс\n");

            //Console.WriteLine("<--------------------> Задание 6 <-------------------->\n");
            //Parallel.Invoke(Inv1, Inv2);

            //Console.WriteLine("<--------------------> Задание 7 <-------------------->\n");
            //BlockColl = new BlockingCollection<string>(5);
            //Task Sup = new Task(Supplier);
            //Task Con = new Task(Consumer);
            //Sup.Start();
            //Con.Start();

            //Task.WaitAll(Sup, Con);
            //Sup.Dispose();
            //Con.Dispose();

            //Console.WriteLine("<--------------------> Задание 8 <-------------------->\n");

            //AsyncEvenNum();
            //Console.ReadKey();
        }

       
        
    }
}
