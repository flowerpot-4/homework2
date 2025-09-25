using System;
using bankEnum;
using bankStruct;


namespace tumakov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            bank bank1 = new bank();
            bank1.accType = Convert.ToString(type.Current);
            bank bank2 = new bank();
            bank1.accType = Convert.ToString(type.Savings);
            Console.WriteLine(bank1.accType, bank2.accType);
            Console.WriteLine();


            Console.WriteLine("Упражнение 3.2");
            bank1.balance = 200;
            bank1.id = 1;
            Console.WriteLine($"номер:{bank1.id} тип:{bank1.accType} баланс:{bank1.balance}");
            Console.WriteLine();


            Console.WriteLine("Домашнее задание 3.1");




        }
    }
}
