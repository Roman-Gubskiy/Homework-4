using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Напишите программу, в которой создайте метод, который принимает в качестве параметров три 
        целочисленных значения и возвращает значение каждого аргумента, умноженного на 10.
        (Использовать out и ref).*/
        static void multiplicationThree1(ref int a, ref int b, ref int c)
        {
            a *= 10;
            b *= 10;
            c *= 10;
            Console.WriteLine($"Используя 'ref' a = {a}, b = {b}, c = {c}");
        }
        static void multiplicationThree2(out int a, out int b, out int c)
        {
            a = 10;
            b = 20;
            c = 30;
            a *= 10;
            b *= 10;
            c *= 10;
            Console.WriteLine($"Используя 'out' a = {a}, b = {b}, c = {c}");
        }
        static void Main(string[] args)
        {
            int num1, num2, num3; // после обработки методом multiplicationThree умножаются на 10
            Console.Write("Введите число а: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите число c: ");
            num3 = int.Parse(Console.ReadLine());
            multiplicationThree1(ref num1, ref num2, ref num3);
            multiplicationThree2(out num1, out num2, out num3);
            Console.ReadKey();
        }
    }
}
