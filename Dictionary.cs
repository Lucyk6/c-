Dictionary<string, string> d = new Dictionary<string, string>(16)
{
    ["id_4"] = "user_1",
    ["id_5"] = "user_2",
    ["id_6"]="user_3"
};
Dictionary<string, string> users = new Dictionary<string, string>(d)//пердаем значение следующего словаря 
{
    ["id_1"] = "user_1",
    ["id_2"] = "user_2",
    ["id_3"] = "user_3"
};
Console.WriteLine(users["id_1"]);
users.TryAdd("id_1", "hello");
//Console.WriteLine(users.TryGetValue(users["id_7"], out string? text));//bool 
users.Count();


KeyValuePair<string, string> a = new KeyValuePair<string, string>("id_1", "user_1");

foreach(var user in users)
{
    Console.WriteLine(user);
}
Console.WriteLine();
foreach (var user in users)
{
    Console.WriteLine($"{ user.Key}- {user.Value}");
}
Console.WriteLine();
foreach(var(key,val)in users)
{
    Console.WriteLine($"{key} - {val}");
}
