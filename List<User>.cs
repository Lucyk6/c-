using System;
using System.Collections.Generic;
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsBanned { get; set; } 

    public override string ToString()
    {
        return $"{Name}, Возраст: {Age}, Статус: {(IsBanned ? "Забанен" : "Активен")}";
    }
}

class Program
{
    public static List<User> FilterUsers(List<User> users, Predicate<User> condition)
    {
        List<User> result = new List<User>();
        foreach (var user in users)
        {
            if (condition(user))
            {
                result.Add(user);
            }
        }
        return result;
    }

    static void Main()
    {
        
        var users = new List<User>
        {
            new User { Name = "Алина", Age = 20, IsBanned = false },
            new User { Name = "Павел", Age = 17, IsBanned = false },
            new User { Name = "Максим", Age = 25, IsBanned = true },
            new User { Name = "Ирина", Age = 30, IsBanned = false },
            new User { Name = "Владимир", Age = 16, IsBanned = true }
        };

        var adults = FilterUsers(users, user => user.Age >= 18);
        Console.WriteLine("Совершеннолетние:");
        foreach (var u in adults)
        {
            Console.WriteLine(u);
        }

        Console.WriteLine();
        
        var bannedUsers = FilterUsers(users, user => user.IsBanned);
        Console.WriteLine("Забаненные:");
        foreach (var u in bannedUsers)
        {
            Console.WriteLine(u);
        }
    }
}
