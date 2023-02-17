using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task45
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое 
        число и определяет количество разрядов данного числа. Пользователь должен иметь 
        возможность вводит число с клавиатуры.*/

        static int CountDigitsRec(int n)
        {
            n = (int)Math.Abs(n); 
            int count = 0; 
            if (n == 0) count = 1;
            while (n != 0) 
            {
                n /= 10; 
                count++; 
            }
            return count;

            /*
            n = (int)Math.Abs(n); // Рекурсией
            if (n <= 9)
            {
                return 1;
            }
            else
            {
                return CountDigitsRec(n / 10) + 1;
            }
            */
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int sum = CountDigitsRec(num);
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
