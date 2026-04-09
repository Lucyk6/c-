using System;
 class Vector2
{
    public int X {  get; set; }
    public int Y { get; set; }
    public Vector2(int x, int y)
    {
        X = x;
        Y= y;
    }
    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);

    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Vector2 a = new Vector2(11,34);
        Vector2 b = new Vector2(69, 65);
        Vector2 c = a + b;
        Console.WriteLine($"{c.X} {c.Y}");

     
    }
}


namespace ConsoleApp25
{
    class Number
    {
        public int Value { get; set; }
        public Number(int value)
        {
            Value = value;
        }
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.Value + b.Value);
        }
        public static Number operator -(Number a, Number b)
        {
            return new Number(a.Value * b.Value);
        }
        public static bool operator true(Number a)
        {
            return a.Value % 2 == 0;
        }
        public static bool operator false(Number a)
        {
            return a.Value % 2 != 0;
        }
        public static Number operator ++(Number i)
        {
            return new Number(i.Value++);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Number(11);
            var b = new Number(10);
            var c = a + b;
            Console.WriteLine(c.Value);
        }
    }
}
//унарный - 1 операнд i++
//бинарный - 2 операнда a + b
//тернарный - 3 операнда a > b ? a : b
