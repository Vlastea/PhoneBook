using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            Print();
            Console.ReadKey();
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine("key: {0}  value: {1}", item.Key, item.Value);
            //}
            //Console.ReadLine();

        }

        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        static void Add()
        {
            Console.WriteLine("Чтобы закончить добавлять новые данные введите пустую строку\n");
            while (true)
            {
                Console.WriteLine("Введите номер телефона(79999999999):");
                string x = Console.ReadLine();
                if (x == "") break;
                Console.WriteLine("Введите ФИО владельца телефона:");
                string y = Console.ReadLine();
                dictionary.Add(x, y);
            }
            Console.Clear();
        }

        static void Print()
        {
            Console.WriteLine("Поиск владельца путём ввода номера телефона\n");
            Console.WriteLine("Введите номер телефона(79999999999):");
            string x = Console.ReadLine();
            string y;
            if (dictionary.TryGetValue(x, out y) == true)
            {
                Console.WriteLine($"ФИО владельца телефона: {y}");
            }
            else
            {
                Console.WriteLine("Номер не зарегистрирован");
            }

        }
    }
}
