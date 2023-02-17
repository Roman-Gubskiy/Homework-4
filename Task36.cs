using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу в которой создайте метод, который принимает в качестве параметров три 
        целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.*/

        /// <summary>
        /// Метод который принимает в качестве параметров три целочисленных аргумента
        /// и выводит на экран среднее арифметическое значений аргументов
        /// </summary>
        /// <param name="a">первый целочисленный аргумент</param>
        /// <param name="b">второй целочисленный аргумент</param>
        /// <param name="c">третий целочисленный аргумент</param>
        /// <returns>вывод сумы по формуле: sum = (a + b + c) / 3</returns>
        static double Average (double a, double b, double c)
        {
            return (a + b + c) / 3;
            //double sum = (a + b + c) / 3;
            //return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите число c: ");
            int num3 = int.Parse(Console.ReadLine());
            double sum = Average(num1, num2, num3);
            Console.WriteLine($"Среднее арифметическое: {Math.Round(sum, 2)}");
            Console.ReadKey();
        }
    }
}
