using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу, которая будет вычислять сумму цифр числа N. Число N пользователь 
        должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки, 
        массивы (ну и циклы, разумеется). (Использовать рекурсию)*/
        static int sumOfDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            int a = n % 10;
            int b = n / 10;
            return a + sumOfDigits(b);
        }
        static void Main(string[] args)
        {
            Console.Write("Для вычислять суммы цифр введите число N: ");
            int num = int.Parse(Console.ReadLine());
            int sum = sumOfDigits(num);
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
