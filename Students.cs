public class Student
{
    public string Name;
    public int Age;

    private static int studentCount = 0;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        studentCount++;
    }
    public static int GetStudentCount()
    {
        return studentCount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Студент: {Name}, Возраст: {Age}");
    }
}
 class Program
{
    static void Main()
    {

        Student s1 = new Student("Лиза", 19);
        Student s2 = new Student("Лусине", 19);
        Student s3 = new Student("Денис", 18);
        Student s4 = new Student("Макс", 18);
        s1.PrintInfo();
        s2.PrintInfo();
        s3.PrintInfo();
        s4.PrintInfo();
        Console.WriteLine($"Всего создано студентов: {Student.GetStudentCount()}");
    }
    
}
