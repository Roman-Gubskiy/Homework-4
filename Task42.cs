using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Написать программу, в которой создайте один метод, который будет вычислять площадь и 
        периметр прямоугольника. Сторони прямоугольника пользователь должен иметь возможность 
        вводит с клавиатуры.*/
        static string areaPerimeter(int a, int b)
        {
             int S = (a * b);
             string S1 = S.ToString();
             int P = (a + b) * 2;
             string P1 = P.ToString();
             string SandP = ($"Площадь прямоугольника = {S1}, периметр = {P1}.");
             return SandP;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите сторону прямоугольника 'а': ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону прямоугольника 'b': ");
            int num2 = int.Parse(Console.ReadLine());
            string total = areaPerimeter(num1, num2);
            Console.Write(total);
            Console.ReadKey();
        }
    }
}
