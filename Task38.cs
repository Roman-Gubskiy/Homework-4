using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task38
{
    internal class Program
             /*Условия:
             Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
             Создайте программу, в которой создайте метод, который принимает в качестве аргумента год 
             рождения пользователя и возвращает его полный возраст.*/
    {
        static int fullAge(int a)
        {
            DateTime year = DateTime.Now;
            return (year.Year - a); // настоящий год - год рождения
        }
        static void Main(string[] args)
        {
            Console.Write("Введите Ваш год рождения: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сейчас Вам {fullAge(yearOfBirth)} полных лет.");
            Console.ReadKey();
        }
    }
}
