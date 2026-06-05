Ссылка на таблицу опций:
https://docs.google.com/spreadsheets/d/1VhdjWwQdX2qGrngZGKX35j38aRfYBptFwqkXvrovJAc/edit?usp=sharing

Пример кода:
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

string filePath = "users.json";

List<User> users = new List<User>
{
    new User("User1", "mail.mail", 28),
    new User("User2", "mail.mail", 29),
    new User("User3", "mail.mail", 27),
    new User("User4", "mail.mail", 31),
};

JsonSerializerOptions options = new JsonSerializerOptions
{
    IncludeFields = true,
    WriteIndented = true
};

using (FileStream file = new FileStream(filePath, FileMode.Create))
{
    JsonSerializer.Serialize<List<User>>(file, users, options);
    Console.WriteLine("Сохранено!");
}

using (FileStream file = new FileStream(filePath, FileMode.OpenOrCreate))
{
    List<User>? deserializedUsers = JsonSerializer.Deserialize<List<User>>(file, options);
    foreach (User user in deserializedUsers)
    {
        Console.WriteLine(user.Name);
    }
}



class User
{
    public static int count;
    public int id;
    [JsonPropertyName("FullName")]
    public string Name { get; set; }
    [JsonIgnore]
    public string Email { get; set; }
    public int Age { get; set; }
    public User (string  name, string email,  int age)
    {
        count++;
        id = count;
        Name = name;
        Email = email;
        Age = age;
    }
}
