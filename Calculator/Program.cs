using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyCalculator");
            //Ввод первого числа (N1):
            Console.WriteLine("Введите 1-ое число:");

            if (!double.TryParse(Console.ReadLine(), out double N1))
            {
                Console.WriteLine("ERROR. Пожалуйста, введите числовое значение.");
                return;
            }

            //Ввод второго числа (N2):
            Console.WriteLine("Введите 2-ое число:");

            if (!double.TryParse(Console.ReadLine(), out double N2))
            {
                Console.WriteLine("ERROR ввода. Пожалуйста, введите числовое значение.");
                return;
            }

            //Выбор операции:
            Console.WriteLine("Выберите какую операцию хотите выполнить: +, -, *, /, ^ (возведение в степень), sqrt (извлечение квадратного корня)");
            string operation = Console.ReadLine();

            //Выполнение операции:
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = N1 + N2;
                    break;
                case "-":
                    result = N1 - N2;
                    break;
                case "*":
                    result = N1 * N2;
                    break;
                case "/":
                    if (N2 != 0)
                    {
                        result = N1 / N2;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: деление на ноль.");
                        return;
                    }
                    break;
                case "^":
                    result = Math.Pow(N1, N2);
                    break;
                case "sqrt":
                    if (N1 >= 0)
                    {
                        result = Math.Sqrt(N1);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: извлечение корня из отрицательного числа.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("ERROR: неверная операция.");
                    return;
            }

            Console.WriteLine($"Результат операции: {result}");
        }
    }
}
