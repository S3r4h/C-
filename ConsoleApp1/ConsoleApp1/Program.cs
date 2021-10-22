using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine( "Введите день недели");
            string days = Console.ReadLine();

            if (days == "1") Console.WriteLine("Понедельник");
            else if (days == "2") Console.WriteLine("Вторник");
            else if (days == "3") Console.WriteLine("Среда");
            else if (days == "4") Console.WriteLine("Четверг");
            else if (days == "5") Console.WriteLine("Пятница");
            else if (days == "6") Console.WriteLine("Суббота");
            else if (days == "7") Console.WriteLine("Воскресенье");
            else Console.WriteLine("Такого дня нету еблан, в неделе всего 7 дней");





        }
    }
}
