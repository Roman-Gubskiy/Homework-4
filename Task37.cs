using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
    internal class Program
    {
        /*Условие:
        спользуя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу в которой создайте метод, который в качестве аргументов принимает 2 
        числа и возвращает меньшее из них.*/

        static int lesserNumber(int a, int b)
        {
            return (a > b) ? b : a;
            //double sum = (a > b) ? b : a;
            //return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int num2 = int.Parse(Console.ReadLine());
            int lesser = lesserNumber(num1, num2);
            Console.WriteLine($"Меньшее число: {lesser}");
            Console.ReadKey();
        }
    }
}
