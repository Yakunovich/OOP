using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создать класс Abiturient: id, Фамилия, Имя, Отчество,
//Адрес, Телефон, массив оценок.Свойства и
//конструкторы должны обеспечивать проверку
//корректности. Добавить методы расчёта среднего балла,
//поиска максимального и минимального балла
//Создать массив объектов. Вывести:
//a) список абитуриентов, имеющих неудовлетворительные
//оценки;
//b) список абитуриентов, у которых сумма баллов выше
//заданной;

namespace ConsoleApp3
{
    
    class Program
    {
        
        const int MAX = 300;
        static void Main(string[] args)
        {
            Abiturient abit1 = new Abiturient();
            var abit = new { name = "Alexandr", surname = "Yakunovich" };      
            string name;
            string surname;
            string patrinomic;
            int number;
            int[] arr = { 2, 3, 5 };
            Abiturient ab1 = new Abiturient("Alex", " Nixon", " Vasilevich", 8231273,arr);         
            Console.WriteLine("Введите кол-во абитуриента(ов)");
            int n = Convert.ToInt32(Console.ReadLine());
            Abiturient[] abiturients = new Abiturient[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                surname = Console.ReadLine();
                Console.WriteLine("Enter patrinomic");
                patrinomic = Console.ReadLine();
                Console.WriteLine("Enter number");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks");
                for(int counter=0;counter<3;counter++)
                {
                    arr[counter] = Convert.ToInt32(Console.ReadLine());
                }
               Abiturient ab2 = new Abiturient(name, surname, patrinomic, number, arr);
                abiturients[i] = ab2;
                // abiturients[i].output();
                
            }

            for (; ; )
            {
                Byte choice;
                Console.WriteLine("1 - список абитуриентов, имеющих неудовлетворительные оценки \n2 - список абитуриентов, у которых сумма баллов выше заданного\n3 - список всех абитуриентов\n0 - Выход");
                choice = Convert.ToByte(Console.ReadLine());
                if (choice == 1)
                {
                    for(int j=0;j<n;j++)
                    {
                        abiturients[j].proverka();
                    
                    }


                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите балл");
                    int ball = Convert.ToInt32(Console.ReadLine());
                    foreach (Abiturient a in abiturients)
                    {
                        if (ball < a.avr)
                        {
                            a.output();
                        }
                    }
                }
                else if (choice == 3)
                {
                    for (int j = 0; j < n; j++)
                    {
                        abiturients[j].output();

                    }

                }
                else if (choice == 0)
                { Environment.Exit(0); }
            }


        }
    }
    class Abiturient
    {
        const string _a = "Abiturient";
        private string name;
        private string surname;
        private string patronymic;
        private int phonenum;
        private int mark;
        public double avr;
        private int[] mas = new int[3];
        static int count = 0;
        public readonly int id;

        public void output()
        {
            Console.WriteLine($"Enterd abiturient :\n Name : {Name} \n Surname : {Surname} \n Patrinomic : {Patronymic} \n Phone number : {Phonenum} \nMath mark : { mas[0]}\n Phisic mark : { mas[1]}\n Lang mark : { mas[2]}\nAverage : {avr}\n\n");
        }
        public Abiturient(string n, string sn, string pat, int phnum, int[] mass)
        {
            Name = n;
            Surname = sn;
            Patronymic = pat;
            Phonenum = phnum;
            for (int ind = 0; ind < 3; ind++)
            {
                Mas[ind] = mass[ind];
            }
            avr = Avr(mass);
            proverka();
            count++;
            Count(count, out id);
        }
 
        public Abiturient()
        {
            Name = "Blank"; 
            Surname = "Blank"; 
            Patronymic = "Blank";
            Phonenum = 0;
            for (int ind=0;ind<3;ind++)
            {
                Mas[ind] = 0;
            }
            avr = Avr(Mas);
            proverka();
            count++;
            Count(count, out id);
            Console.WriteLine("Вы создали объект");
            
        }
        static Abiturient()
        {
            string _a = "I'm abiturient";
            Console.WriteLine(_a);
            
        }
        

        public int[] Mas
        {

            set
            {
                mas = value;
            }

            get { return mas; }


        }
        public void proverka()
            {
            foreach(int a in mas)
            {
                if (a<4)
                {
                    output();
                    break;
                }
            }
            }
       
        public double Avr(int[] A)
        {
            int i = 0;
            for(int j=0;j<A.Length;j++)
            {
                i = A[j] + i;
            }
            return Convert.ToDouble(i) / A.Length;
        }
        public int Mark
        {
            set
            {
                
                mark = value;
            }
            get
            {
                return mark;
            }
        }
        //public int avr()
        //{
        //    return
        //}
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }
        public string Patronymic
        {
            set
            {
                patronymic = value;
            }
            get
            {
                return patronymic;
            }
        }
        public int Phonenum
        {
            set
            {
                phonenum = value;
            }
            get
            {
                return phonenum;
            }
        }
        static void Count(int c, out int b)
        {
            b = c;
        }
        public static void Info()
        {
            Console.WriteLine($"Введено {count} абитуриентов");
        }
        public override string ToString()
        {
            return  Name + " " + Surname +" " + Patronymic;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Abiturient abiturient = (Abiturient)obj;
            return (this.Name == abiturient.Name && this.Surname == abiturient.Surname && this.Patronymic == abiturient.Patronymic);
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        
    }
   
}
