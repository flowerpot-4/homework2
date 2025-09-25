using drinkStruck;
using studentStruct;
using System;
using userStruct;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Тип\n      максимальное значение   минимальное значение");
            Console.WriteLine("bool\n     True  False");
            Console.WriteLine($"byte\n     {byte.MaxValue} {byte.MinValue}");
            Console.WriteLine($"sbyte\n     {sbyte.MaxValue} {sbyte.MinValue}");
            Console.WriteLine($"char\n     {char.MaxValue} {char.MinValue}");
            Console.WriteLine($"decimal\n     {decimal.MaxValue} {decimal.MinValue}");
            Console.WriteLine($"double\n     {double.MaxValue} {double.MinValue}");
            Console.WriteLine($"float\n     {float.MaxValue} {float.MinValue}");
            Console.WriteLine($"int\n     {int.MaxValue} {int.MinValue}");
            Console.WriteLine($"uint\n     {uint.MaxValue} {uint.MinValue}");
            Console.WriteLine($"long\n    {long.MaxValue} {long.MinValue}");
            Console.WriteLine($"ulong\n    {ulong.MaxValue} {ulong.MinValue}");
            Console.WriteLine($"short\n   {short.MaxValue} {short.MinValue}");
            Console.WriteLine($"ushort\n   {ushort.MaxValue} {ushort.MinValue}");
            Console.WriteLine();


            Console.WriteLine("Task 2");
            Console.WriteLine("Введите данные в формате:\nИмя\nГород\nВозраст\nПинкод");
            user user1 = new user();
            user1.name = Console.ReadLine();
            user1.city = Console.ReadLine();
            user1.age = Convert.ToInt16(Console.ReadLine());
            user1.pin = Console.ReadLine();
            Console.WriteLine($"Данные пользователя:\nИмя:{user1.name}\nГород:{user1.city}\nВозраст:{user1.age}\nПинкод:{user1.pin}");
            Console.WriteLine();


            Console.WriteLine("Task 3");
            Console.WriteLine("Введите строку");
            string inputStr = Console.ReadLine();
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == Char.ToLower(inputStr[i]))
                {
                    Console.Write(Char.ToUpper(inputStr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(inputStr[i]));
                }
            }
            Console.WriteLine();


            Console.WriteLine("Task 4");
            Console.WriteLine("Введите данные в формате:\nСтрока\nПодстрока");
            string given = Console.ReadLine();
            string toFind = Console.ReadLine();
            int count = 0;
            int len = toFind.Length;
            for (int i = 0; i <= given.Length - len; i++)
            {
                if (given.Substring(i, len) == toFind)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} вхожд.");
            Console.WriteLine();


            Console.WriteLine("Task 5");
            Console.WriteLine("Введите данные в формате:\nстандартная цена\nскидка\nстоимость отпуска");
            int normPrice = Convert.ToInt16(Console.ReadLine());
            double salePrice = Convert.ToDouble(Console.ReadLine()) * 0.01;
            int holidayPrice = Convert.ToInt16(Console.ReadLine());
            int bottleNum = Convert.ToInt32(Math.Floor((holidayPrice / (normPrice - normPrice * (1 - salePrice)))));
            Console.WriteLine($"{bottleNum} бутылок.");
            Console.WriteLine();


            Console.WriteLine("Task 6");
            drink vodka = new drink();
            vodka.name = "водка";
            vodka.alcPercent = 40;
            drink vine = new drink();
            vodka.name = "вино";
            vodka.alcPercent = 8;
            student[] students = {
                new student
                {
                lastName = "Петров",
                firstName = "Петя",
                Id = 1,
                date = 2004,
                alcCategory = 'c',
                drinkType = vodka,
                drinkVol= 4
                },

                new student
                {
                lastName = "Петров",
                firstName = "Федр",
                Id = 2,
                date = 2005,
                alcCategory = 'b',
                drinkType = vodka,
                drinkVol= 7.6
                },
                new student
                {
                lastName = "Соколова",
                firstName = "Лиза",
                Id = 3,
                date = 2003,
                alcCategory = 'd',
                drinkType = vine,
                drinkVol= 1
                },
                new student
                {
                lastName = "Соколова",
                firstName = "Аня",
                Id = 4,
                date = 2000,
                alcCategory = 'ф',
                drinkType = vodka,
                drinkVol= 8.2
                },
                new student
                {
                lastName = "Иванов",
                firstName = "Игорь",
                Id = 5,
                date = 2006,
                alcCategory = 'b',
                drinkType = vine,
                drinkVol= 3.2
                },
            };
            double allVolume = 0;
            double allAlc = 0;
            for (int i = 0; i < students.Length; i++)
            {
                allVolume += students[i].drinkVol;
                allAlc += (students[i].drinkVol * students[i].drinkType.alcPercent/100);
            }
            for (int i = 0; i < students.Length; i++)
            {

            }
            Console.ReadKey();
        }
    }
}
