using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task46
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли 
        клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. 
        Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может 
        двумя платежами по 300 и 400 грн. Закрыть весь долг.
        Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную 
        экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма 
        задолженности, сумма переплаты, сообщение об отсутствии долга).*/
        static int credit(int t, int y)
        {
            int a = t, c = y;
            if (a >= 100 && a < c)
            {
                c -= a;
                Console.WriteLine($"Сумма задолжености {c} грн.");
                return c;                
            }
            else if (a > c)
            {
                c -= a;
                c = Math.Abs(c);
                Console.WriteLine($"Кредит погашен, переплата {c} грн.");
                return c;
            }
            else if (a == c)
            {
                c -= a;
                Console.WriteLine($"Кредит полноностью погашен задолженость {c}, переплата {c} грн.");
                return c;
            }
            else
            {
                Console.WriteLine("Вы не ввели минимальную сумму!");
                return c;
            }
        }   

        static void Main(string[] args)
        {
            int a;
            int c = 700;

            Console.WriteLine($"Ваш долг по кредиту {c}, минимальная сума платежа 100 грн.");
            a = int.Parse(Console.ReadLine());
            credit(a, c);
            Console.ReadKey();

            // Решение через if else
            /*
            int a;
            int c = 700;
            
            Console.WriteLine($"Ваш долг по кредиту {c}, минимальная сума платежа 100 грн.");
        start:
            Console.WriteLine($"Погасить?");
            a = int.Parse(Console.ReadLine());
            if (a >= 100 && a < c)
            {
                c -= a;
                Console.WriteLine($"Сумма задолжености {c} грн.");
                goto start;
            }
            else if (a > c)
            {
                c -= a;
                c = Math.Abs(c);
                Console.WriteLine($"Кредит погашен, переплата {c} грн.");
            }
            else if (a == c)
            {
                c -= a;
                Console.WriteLine($"Кредит полноностью погашен задолженость {c}, переплата {c} грн.");              
            }
            else
            {
                Console.WriteLine("Вы не ввели минимальную сумму!");
            }
            Console.ReadKey();
            */
        }
    }
}
