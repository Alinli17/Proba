using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // для работы с текстовым документом

namespace Proba
{
    class Program
    {
        private static int n; // размер массива
        private static Autos[] Autos; // создали мвссив Autos (пустой)

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                string n1 = Console.ReadLine();

                while (!Int32.TryParse(n1, out n)) // проверка на введенное целое число
                {
                    Console.WriteLine("Введите целое число!");
                    Console.Write("Введите размер массива: ");
                    n1 = Console.ReadLine();
                    Console.WriteLine();
                }

                Autos = new Autos[n]; // создали массив с n элементами
                ReadAutos();
                Sort();
                Save();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }

        static public void ReadAutos()
        {
            for (int i = 0;  i < n; i++)
            {
                Autos[i] = new Autos();

                Console.Write("Введите название машины {0}: ", i + 1);
                string name = Console.ReadLine();

                while (string.IsNullOrEmpty(name)) // проверка на то, что что-то ввели (не пусто)
                {
                    Console.Write("Введите название машины {0}: ", i + 1);
                    name = Console.ReadLine();
                }

                Autos[i].Name = name;

                Console.Write("Введите марку машины {0}: ", i + 1);
                string model = Console.ReadLine();

                while (string.IsNullOrEmpty(model)) // проверка на то, что что-то ввели (не пусто)
                {
                    Console.Write("Введите марку машины {0}: ", i + 1);
                    model = Console.ReadLine();
                }

                Autos[i].Model = model;

                Console.Write("Введите цену машины {0}: ", i + 1);
                string price1 = Console.ReadLine();
                int price;

                while (string.IsNullOrEmpty(price1)) // проверка на то, что что-то ввели (не пусто)
                {
                    Console.Write("Введите цену машины {0}: ", i + 1);
                    price1 = Console.ReadLine();
                }

                while (!Int32.TryParse(price1, out price)) // проверка, если ввели букву, а не цифру
                {
                    Console.WriteLine("Введите целое число!");
                    Console.Write("Введите размер массива: ");
                    price1 = Console.ReadLine();
                    Console.WriteLine();
                }

                Autos[i].Price = price;
            }
        }

        static public void Sort()
        {
            //// сортировка по убыванию (название + цена) название приоритетнее: если названия одинаковые, то по цене
            //Autos = Autos.AsQueryable<Autos>().OrderByDescending(a => a.Name).ThenByDescending(a => a.Price).ToArray();

            //сортировка по возрастанию (название + цена) название приоритетнее: если названия одинаковые, то по цене
            Autos = Autos.AsQueryable<Autos>().OrderBy(a => a.Name).ThenBy(a => a.Price).ToArray();

            Console.WriteLine("Отсортировано!");
        }

        static public void Save() // метод для записи в файл
        {
            using (StreamWriter stream = new StreamWriter("C:/proba/file.txt"))
            {
                foreach (Autos autos in Autos)
                {
                    stream.WriteLine(autos.Name + "; " + autos.Model + "; " + autos.Price + ".");
                }
                Console.WriteLine("Сохранение прошло успешно!");
            }
        }
    }
}
