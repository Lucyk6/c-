using System;
static class MathUtils
{
    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    public static int Factorial(int number)
    {
        if (number == 1 || number == 0)
            return 1;
        else
            return number * Factorial(number - 1);
    }
    public static double Power(double a, int b)
    {
        double result = 1;
        if (b > 0)
        {
            for (int i = 1; i <= b; ++i)
            {
                result *= a;
            }
        }
        else if (b < 0)
        {
            for (int i = -1; i >= b; --i)
            {
                result /= a;
            }
        }
        return result;


    }
  public static int Clamp(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }


}
class Program
{
    static void main()
    {
        Console.WriteLine($"IsEven(7): {MathUtils.IsEven(5)}");
        Console.WriteLine($"IsEven(8): {MathUtils.IsEven(10)}");
        Console.WriteLine($"Factorial(5): {MathUtils.Factorial(5)}");
        Console.WriteLine($"Power(2, 3): {MathUtils.Power(5, 3)}");
        Console.WriteLine($"Power(2, -2): {MathUtils.Power(6, -2)}");
        Console.WriteLine($"Clamp(15, 0, 10): {MathUtils.Clamp(15, 0, 10)}");
        Console.WriteLine($"Clamp(5, 0, 10): {MathUtils.Clamp(5, 0, 10)}");
        Console.WriteLine($"Clamp(-3, 0, 10): {MathUtils.Clamp(-3, 0, 10)}");
    }



}
