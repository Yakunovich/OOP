using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int h=3, w=3;
            Matrix matrix1 = new Matrix(h,w);
            //Matrix matrix2 = new Matrix(h,w);
            //Console.WriteLine((int)matrix1); 
            //Console.WriteLine(matrix1==matrix2);
            //Matrix matrix3 = matrix1 + matrix2;
            //matrix3.output();
            //matrix1--;
            //matrix1.output();

            //Matrix.Date data = new Matrix.Date(11, 12, 2001);
            //Console.WriteLine();
            ////Matrix.Owner owner = new Matrix.Owner(1, "Alexey", "BelTel");
            ////owner.PrintOwver();
            //matrix1.FirstNumb(1);
            matrix1.PrintOw();
            


        }



    }
}
public class Matrix
{
   public class Date
   {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public Date(int day,int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

    }
    Owner owner = new Owner(1, "Vasiliy", "Galileo");
    public void PrintOw()
    {
        Console.WriteLine(owner.Id + " " + owner.Name+" "+owner.Organization);
    }
    
    private int h, w;
    private int[,] numbers;
    public Matrix(int h, int w)
    {
        this.h = h;
        this.w = w;
        Console.WriteLine("Enter matrix");
        numbers = new int[h, w];
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                numbers[i, j] = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
    public int H
    {
        get => h;
        set => h = value;
    }
    public int W
    {
        get => w;
        set => w = value;
    }
    public void output()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0} ", numbers[i, j]);
            }
            Console.WriteLine();
        }
    }
    public Matrix()
    {

    }

    public int this[int i, int j]
    {
        get
        {
            return numbers[i, j];
        }
        set
        {
            numbers[i, j] = value;
        }
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public static Matrix operator +(Matrix one, Matrix two)
    {
        if (one.w == two.w && one.h == two.h)
        {
            Matrix m = new Matrix();
            m.w = one.w;
            m.h = one.h;
            m.numbers = new int[m.w, m.h];
            for (int i = 0; i < one.h; i++)
            {
                for (int j = 0; j < one.w; j++)
                {
                    m.numbers[i, j] = one.numbers[i, j] + two.numbers[i, j];
                }
            }
            return m;
        }
        return one;
    }
    public static Matrix operator --(Matrix one)
    {
        for (int i = 0; i < one.h; i++)
        {
            for (int j = 0; j < one.w; j++)
            {
                one.numbers[i, j] = 0;
            }
        }
        return one;
    }
    public static bool operator ==(Matrix one, Matrix two)
    {
        if (one.h == two.h)
        {
            for (int i = 0; i < 3; i++)
            {
                if (one[i, 0] == two[i, 0])
                {
                    return true;

                }

            }
        }
        return false;
    }
    public static bool operator !=(Matrix one, Matrix two)
    {
        if (one.h == two.h)
        {
            for (int i = 0; i < 3; i++)
            {
                if (one[i, 0] == two[i, 0])
                {
                    return false;

                }

            }
        }
        return true;
    }
    public static explicit operator int(Matrix counter)
    {
        int n = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (counter[i, j] == 0) n++;
            }
        }
        return n;
    }

    

}
public class Owner
{
    int id;
    string name;
    string organization;
    public Owner(int a, string b, string c)
    {
        Id = a;
        Name = b;
        Organization = c;
    }
    public int Id
    {
        get => id;
        set => id = value;
    }
    public string Name
    {
        get => name;
        set => name = value;

    }
    public string Organization
    {
        get => organization;
        set => organization = value;
    }
    public void PrintOwver()
    {
        Console.WriteLine(Id + " " + Name + " " + Organization);
    }
}


//Класс - Марица.Дополнительно перегрузить следующие
//операции: + - сложение матриц; -- обнуление всех элементов
//матрицы; == - сравнение матриц по нулевому столбцу; явный
//int () – количество отрицательных элементов в матрице.
// Методы расширения:
//1) Выделение первого числа, содержащегося в строке
//2) Обнуление отрицательных элементов матрицы 
//1) Создать заданный в варианте класс.Определить в классе необходимые
//методы, конструкторы, индексаторы и заданные перегруженные
//операции.Написать программу тестирования, в которой проверяется
//использование перегруженных операций.
//2) Добавьте в свой класс вложенный объект Owner, который содержит Id,
//имя и организацию создателя.Проинициализируйте его
//3) Добавьте в свой класс вложенный класс Date(дата создания).
//Проинициализируйте
//4) Создайте статический класс StatisticOperation, содержащий 3 метода для
//работы с вашим классом(по варианту п.1): сумма, разница между
//максимальным и минимальным, подсчет количества элементов.
//5) Добавьте к классу StatisticOperation методы расширения для типа string
//и вашего типа из задания№1. См.задание по вариантам. 