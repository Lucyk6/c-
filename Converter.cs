using System;
public interface IConverter
{
    double Convert(double value);
}
public class LengthConverter : IConverter
{
    private string fromUnit;
    private string toUnit;

    public LengthConverter(string fromUnit, string toUnit)
    {
        this.fromUnit = fromUnit;
        this.toUnit = toUnit;
    }

    public double Convert(double value)
    {
        if (fromUnit == "meters" && toUnit == "kilometers")
            return value / 1000;
        if (fromUnit == "kilometers" && toUnit == "meters")
            return value * 1000;

        throw new Exception($"Преобразование {fromUnit} в {toUnit} не поддерживается");
    }
}

public class WeightConverter : IConverter
{
    private string fromUnit;
    private string toUnit;

    public WeightConverter(string fromUnit, string toUnit)
    {
        this.fromUnit = fromUnit;
        this.toUnit = toUnit;
    }

    public double Convert(double value)
    {
        if (fromUnit == "kg" && toUnit == "pounds")
            return value * 2.20462;
        if (fromUnit == "pounds" && toUnit == "kg")
            return value / 2.20462;

        throw new Exception($"Преобразование {fromUnit} в {toUnit} не поддерживается");
    }
}

public class TemperatureConverter : IConverter
{
    private string fromUnit;
    private string toUnit;

    public TemperatureConverter(string fromUnit, string toUnit)
    {
        this.fromUnit = fromUnit;
        this.toUnit = toUnit;
    }

    public double Convert(double value)
    {
        if (fromUnit == "C" && toUnit == "F")
            return (value * 9 / 5) + 32;
        if (fromUnit == "F" && toUnit == "C")
            return (value - 32) * 5 / 9;

        throw new Exception($"Преобразование {fromUnit} в {toUnit} не поддерживается");
    }
}

class Program
{
    static void Main()
    {
        var lengthConverter = new LengthConverter("meters", "kilometers");
        Console.WriteLine("1000 метров в километрах: " + lengthConverter.Convert(1000));

        var weightConverter = new WeightConverter("kg", "pounds");
        Console.WriteLine("5 кг в фунтах: " + weightConverter.Convert(5));

        var tempConverter = new TemperatureConverter("C", "F");
        Console.WriteLine("25 градусов Цельсия в Фаренгейты: " + tempConverter.Convert(25));
    }
}
