using System;
public class Employee
{
    public string Name { get; set; }

    public virtual double CalculateSalary()
    {
        return 0;
    }


}
public class Teacher : Employee
{
    public double Rate { get; set; }       
    public double Bonus { get; set; }  

    public override double CalculateSalary()
    {
        return Rate + Bonus;
    }
}

public class Administrator : Employee
{
    public double FixedSalary { get; set; }

    public override double CalculateSalary()
    {
        return FixedSalary;
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Teacher { Name = "Maksim", Rate = 20000, Bonus = 500 },
            new Teacher { Name = "Liza", Rate = 100000, Bonus = 3000 },
            new Administrator { Name = "Liza", FixedSalary = 400000 },
            new Administrator { Name = "Alexandr", FixedSalary = 45000 },
        };
        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Name} — зарплата: {emp.CalculateSalary()}");
        }
    }

}
