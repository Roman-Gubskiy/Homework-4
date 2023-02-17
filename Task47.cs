using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу, которая находит сумму  1+2+3+…+n, где число n вводится пользователем с 
        клавиатуры.*/
        static int numbers(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            return numbers(n - 1) + n;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"числа от {numbers(num)} до. ");
            Console.ReadKey();
        }
    }
}
