namespace ConsoleApp10
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Text;
    internal class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Student(string? name, int age)
        {
            Age = age;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>()
            {
               new Student("Liza",18),
               new Student(" ", 24)
            };
            students.CollectionChanged += StudentChanged;

            students.Add(new Student("alex", 19));
            students.Add(new Student("alex", 19));
            students.Add(new Student("alex", 19));

            void StudentChanged(object? sender, NotifyCollectionChangedEventArgs e)
            {
                if (e.NewItems?[0] is Student student)
                {
                    Console.WriteLine("ADDED");
                    foreach (var students in e.NewItems)
                    {
                        Console.WriteLine(students);

                    }

                }
            }
        }

    }
}
/*void StudentChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            if (e.NewItems?[0] is Student newStudent)
                Console.WriteLine($"Добавлен новый объект: {newStudent.Name}");
            break;
        case NotifyCollectionChangedAction.Remove:
            if (e.OldItems?[0] is Student oldStudent)
                Console.WriteLine($"Удален объект: {oldStudent.Name}");
            break;
        case NotifyCollectionChangedAction.Replace:
            if ((e.NewItems?[0] is Student newStudentReplace) &&
                (e.OldItems?[0] is Student oldStudentReplace))
                Console.WriteLine($"Объект {oldStudentReplace.Name} заменен объектом {newStudentReplace.Name}");
            break;
    }
}*/
