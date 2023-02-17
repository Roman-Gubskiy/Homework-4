using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу для конвертирования валюты. Пользователь должен иметь возможность 
        ввести курс валюты, в которую он хочет конвертировать, сумму которую он хочет 
        конвертировать.  Программа должна вывести сумму денег в соответствующей валюте.*/

        static double currencyExchange(double a, double b)
        {
            double sum = Math.Round(b / a, 2);
            Console.WriteLine($"По указаному курсу вы получите: {sum}");
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите курс валюты: ");
            double well = double.Parse(Console.ReadLine());
            Console.Write("Введите сумму для обмена по курсу: ");
            double sum = double.Parse(Console.ReadLine());
            currencyExchange(well, sum);
            Console.ReadKey();
        }
    }
}
