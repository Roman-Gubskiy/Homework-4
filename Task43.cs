using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. N – число 
        которое пользователь вводит с клавиатуры. (Использовать рекурсию)*/
        static int numbers(int n, int i = 0)
        {
            i++;
            Console.Write($"{(i)}, ");
            if (n == i)
            {
                return 0;
            }
            return numbers(n, i);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            numbers(num);
            Console.ReadKey();
        }
        //Рекурсия через string
        /*
        static string numbers(int n)
        {
            if (n == 1)
            {
                return " 1 ";
            }
            return numbers(n - 1) + n + " ";
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"числа от {numbers(num)} до. ");
            Console.ReadKey();
        }
        */
        // Не рекурсия
        /*
        static int numbers(int n)
        {
            int counter = 1;
            while (n >= counter)
            {
                Console.Write($"{(counter)}, ");
                counter++;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            numbers(num);
            Console.ReadKey();
        }
        */
        // Не рекурсия
        /*
         static int CountDigitsRec(int n)
        {
            n = (int)Math.Abs(n);
            int count = 0;
            if (n == 0) count = 1;
            while (n != 0)
                n -= 1;
                count++;
                Console.WriteLine($"{count} ");
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int sum = CountDigitsRec(num);
            Console.Write(sum);
            Console.ReadKey();
        }
        */

    }
}
