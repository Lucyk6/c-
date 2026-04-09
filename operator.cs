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
