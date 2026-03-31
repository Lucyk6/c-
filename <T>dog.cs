using System;

public class Box<T>
{
    private T value;
    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}
public class Dog
{
    public string dog_breed { get; set; }

    public override string ToString()
    {
        return $"Dog's breed is {dog_breed}";
    }
}

class Program
{
    static void Main()
    {
     
        Box<int> intBox = new Box<int>();
        intBox.SetValue(123);
        Console.WriteLine("Int value: " + intBox.GetValue());

    
        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Привет");
        Console.WriteLine("String value: " + stringBox.GetValue());

        Box<Dog> personBox = new Box<Dog>();
        personBox.SetValue(new Dog { dog_breed = "doberman" });
        Console.WriteLine("Person value: " + personBox.GetValue());
    }
}
