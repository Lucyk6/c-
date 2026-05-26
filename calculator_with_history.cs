using System;
using System.Collections.Generic;

namespace HumanCalculator
{
    // Класс калькулятора (только чистая логика вычислений)
    public class Calculator
    {
        // Событие, которое будет сообщать о результате операции
        public event Action<string> OnResult;

        // Главный метод: принимает два числа и лямбду (саму математическую операцию)
        public double Calculate(double a, double b, Func<double, double, double> operation)
        {
            // Выполняем вычисление, которое нам передали
            double result = operation(a, b);

            // Если кто-то подписался на событие — отправляем текст с результатом
            // (Кстати, знак '?' проверяет, есть ли подписчики, чтобы программа не упала)
            OnResult?.Invoke($"Операция над {a} и {b}. Результат: {result}");

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Calculator calc = new Calculator();
            List<string> history = new List<string>();

            calc.OnResult += (msg) => history.Add($"{DateTime.Now:HH:mm:ss}: {msg}");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Новое вычисление");
                Console.WriteLine("2. Показать историю операций");
                Console.WriteLine("3. Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                if (choice == "3") break;

                switch (choice)
                {
                    case "1":

                        Console.Write("Введите первое число (A): ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число (B): ");
                        double num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Выберите операцию: + , ^ , -, *");
                        string op = Console.ReadLine();

                        double result = 0;

                        if (op == "+")
                        {
                            result = calc.Calculate(num1, num2, (a, b) => a + b);
                        }
                        else if (op == "-")
                        {
                            result = calc.Calculate(num1, num2, (a, b) => a - b);
                        }
                        else if (op == "^")
                        {
                            result = calc.Calculate(num1, num2, (a, b) => Math.Pow(a, b));
                        }
                        else if (op == "*")
                        {
                            result = calc.Calculate(num1, num2, (a, b) => a*b);
                        }
                        else
                        {
                            Console.WriteLine("Неизвестная операция!");
                            continue;
                        }

                        Console.WriteLine($"\nОтвет на экране: {result}");
                        break;

                    case "2":
                        
                        if (history.Count == 0)
                        {
                            Console.WriteLine("История пока пуста.");
                        }
                        else
                        {
                            foreach (string entry in history)
                            {
                                Console.WriteLine(entry);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            }
        }
    }
}
