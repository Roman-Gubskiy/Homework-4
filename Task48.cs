using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task48
{
    internal class Program
    {       
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Написать программу, которая запрашивает от пользователя ввод Pin кода три раза, если 
            пользователь три раза ввел не правильный Pin код, то необходимо вывести сообщение о том
            что его карта заблокирована, если же пользователь ввел Pin код правильно, то необходимо
            поздороваться с ним. */

        static void pin(int pin2, int pin1)
        {
            int a = pin2, b = pin1;
            for (int i = 2; i > 0; i--)
            {
                if (a == b)
                {
                    Console.WriteLine($"PIN верный!");
                    Console.ReadKey();
                    break;
                }
                if (a != b)
                {
                    Console.WriteLine($"Осталось {i} попыток");
                    a = int.Parse(Console.ReadLine());
                }
                if (i == 1)
                {
                    Console.WriteLine($"Попытки ввести PIN закончились!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b = 1111;
            Console.WriteLine($"Введите PIN:");
            a = int.Parse(Console.ReadLine());
            pin(a, b);

            // Циклом if esle
            //int a, b = 1111;
            //Console.WriteLine($"Введите PIN:");
            //a = int.Parse(Console.ReadLine());
            //for (int i = 2; i > 0; i--)
            //{
            //    if (a == b)
            //    {
            //        Console.WriteLine($"PIN верный!");
            //        Console.ReadKey();
            //        break;                    
            //    }                
            //    if (a != b)
            //    {
            //        Console.WriteLine($"Осталось {i} попыток");
            //        a = int.Parse(Console.ReadLine());
            //    }
            //    if (i == 1)
            //    {
            //        Console.WriteLine($"Попытки ввести PIN закончились!");
            //        break;
            //    }
            //}
        }
    }
}
