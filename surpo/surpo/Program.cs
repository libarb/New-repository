using System;

namespace surpo
{
    class Cat
    {
        public string Name { get; set; } //имя
        private string breed; //порода

        public Cat(string name, string breed)
        {
            Name = name;
            this.breed = breed;

        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        public string GetInfo()
        {
            return String.Format("Кот {0}, порода: {1}", Name, breed);
        }

        public string GetInfo(bool includeIntProperty)
        {
            if (includeIntProperty)
                return GetInfo();
            else
                return String.Format("Кот {0}, порода: {1}", Name, Breed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Вася", "мейн-кун");
            Console.WriteLine(cat.GetInfo() + "\n");
            string name, breed;
            Console.Write("Введите имя кота: ");
            name = Console.ReadLine();
            Console.Write("Введите породу кота: ");
            breed = Console.ReadLine();
            cat.Name = name;
            cat.Breed = breed;

            Console.WriteLine();
            Console.WriteLine(cat.GetInfo(true)); //вывод полной инфы
            Console.WriteLine(cat.GetInfo(false)); //вывод инфы без возраста
            Console.ReadKey();
        }
    }
}
