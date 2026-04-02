using System;

class Program
{
    static void Main()
    {
        Predicate<string> isNotNullOrEmpty = s => !string.IsNullOrEmpty(s);

        Predicate<int> isInRange = num => num >= 1 && num <= 100;

        bool Validate<T>(T value, Predicate<T> predicate)
        {
            return predicate(value);
        }

        string testString1 = "Hello";
        string testString2 = "";
        string testString3 = null;

        Console.WriteLine($"Строка '{testString1}' валидна: {Validate(testString1, isNotNullOrEmpty)}");
        Console.WriteLine($"Строка '{testString2}' валидна: {Validate(testString2, isNotNullOrEmpty)}");
        Console.WriteLine($"Строка 'null' валидна: {Validate(testString3, isNotNullOrEmpty)}");

        int[] testNumbers = { 0, 50, 150, 75 };

        foreach (var num in testNumbers)
        {
            Console.WriteLine($"Число {num} в диапазоне 1-100: {Validate(num, isInRange)}");
        }
    }
}
2)
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Func<int, int> square = x => x * x;
        Action<int> print = x => Console.WriteLine($"Результат: {x}");

        var squaredNumbers = numbers.Select(square).ToList();

        Console.WriteLine("Квадраты чисел:");
        squaredNumbers.ForEach(print);

        numbers
            .Select(square)       
            .Where(x => x > 10)   
            .ToList()
            .ForEach(print);
    }
}
