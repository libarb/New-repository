using System;

namespace surpo
{
    class Cat
    {
        public string Name { get; set; } //имя

        public Cat(string name)
        {
            Name = name;
        }
       

        public string GetInfo()
        {
            return String.Format("Кот {0}", Name);
        }

        public string GetInfo(bool includeIntProperty)
        {
            if (includeIntProperty)
                return GetInfo();
            else
                return String.Format("Кот {0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Вася");
            Console.WriteLine(cat.GetInfo() + "\n");
            string name;
            Console.Write("Введите имя кота: ");
            name = Console.ReadLine();
            
            cat.Name = name;
            Console.WriteLine();
            Console.WriteLine(cat.GetInfo(true)); //вывод полной инфы
            Console.WriteLine(cat.GetInfo(false)); //вывод инфы без возраста
            Console.ReadKey();
        }
    }
}
