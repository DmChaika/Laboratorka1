using System;
using System.Collections;

namespace Table
{
    public class OOP
    {

        public struct Item
        {
            public String Name;
            public String rez;
            public int year;
            public String Type;

            public Item(String Name, String rez, int year, String Type)
            {
                this.Name = Name;
                this.rez = rez;
                this.year = year;
                this.Type = Type;

            }

            public void Print()
            {
                Console.WriteLine($"|{this.Name,-24}||{this.rez,-20}|{this.year,-15}|{this.Type,-12}");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Автор книги:");
                string name = Console.ReadLine();

                Console.WriteLine("Название");
                string rez = Console.ReadLine();

                Console.WriteLine("Год выпуска");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Группа: Х - художественная литература; У - учебная лит-ра; С - справочная лит-ра ");
                string Type = Console.ReadLine();

                Item value = new(name, rez, year, Type);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить строку?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|каталог библиотеки",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Автор книги",-25}|{"Название",-20}|{"Год выпуска",-15}|{"Группа ",-12}");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Х - художественная литература; У - учебная лит-ра; С - справочная лит-ра ",-75}|");
            Console.WriteLine(new String('-', 76));
        }
    }
}