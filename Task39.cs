using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task39
{
    internal class Program

        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу консольный калькулятор.В данной программе должны быть четыре
        метода, метод для сложения, вычитания, умножения и деления.Каждый из методов должен
        принимать 2 целочисленных аргумента и выполнять соответствующею действие. Метод для
        деления должен выполнять проверку деления на ноль.Также необходимо предоставить
        пользователю возможность вводить знак арифметической операции, в зависимости от знака
        вызывать соответствующий метод.Также пользователю необходимо предоставить возможность
        вводит значения аргументов.*/
    {
        static double Eddition(double a, double b)
        {
            double sum = Math.Round(a + b, 2);
            Console.WriteLine($"{a} + {b} = {sum}");            
            return sum;
        }
        static double Subtraction(double a, double b)
        {
            double sum = Math.Round(a - b, 2);
            Console.WriteLine($"{a} - {b} = {sum}");
            return sum;
        }
        static double Multiplication(double a, double b)
        {
            double sum = Math.Round(a * b, 2);
            Console.WriteLine($"{a} * {b} = {sum}");
            return sum;
        }
        static double Division(double a, double b)
        {
            double sum = Math.Round(a / b, 2);
            if (b != 0) // (!(b == 0))
            {
                Console.WriteLine($"{a} / {b} = {sum}");
                return sum;
            }
            else if (b == 0)
            {
                Console.WriteLine($"{a} / {b} = {0}"); // проверка деление на 0 = 0!
                return 0;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double operand2 = double.Parse(Console.ReadLine());
            Console.Write("Выберите действие + , - , / , * ,: ");
            string sign = (Console.ReadLine());

            switch (sign)
            {
                case "+":
                    Eddition(operand1, operand2);
                    break;
                case "-":
                    Subtraction(operand1, operand2);
                    break;
                case "*":
                    Multiplication(operand1, operand2);
                    break;
                case "/":
                    Division(operand1, operand2);
                    break;
                default:
                    Console.WriteLine("Неверное действие!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
