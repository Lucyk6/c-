//using System;

//class Seat
//{
//    public decimal Price { get; set; }
//    public bool IsBooked { get; set; }
//}

//class CinemaHall
//{
//    public Seat[,] seats = new Seat[5, 10];

//    public CinemaHall()
//    { 
//        for (int row = 0; row < 5; row++)
//        {
//            decimal currentPrice = 500 - (row * 50);

//            for (int col = 0; col < 10; col++)
//            {
//                seats[row, col] = new Seat();
//                seats[row, col].Price = currentPrice;
//                seats[row, col].IsBooked = false;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CinemaHall hall = new CinemaHall();

//        Console.WriteLine($"Цена на 1 ряду: {hall.seats[0, 0].Price} руб.");

//        Console.WriteLine($"Цена на 5 ряду: {hall.seats[4, 0].Price} руб.");
//    }
//}
using System;

class Program
{
    static void Main()
    {
        string[] deliveryLogs = {
            "Иван:Москва:450",
            "Ольга:Санкт-Петербург:500",
            "Иван:Москва:300",
            "Алексей:Краснодар:400",
            "Ольга:Москва:600",
            "Иван:Краснодар:350",
            "Алексей:Краснодар:200"
        };

        List<string> Cities = new List<string>();
        Dictionary<string, List<int>> curiers = new Dictionary<string, List<int>>();
        foreach (string item in deliveryLogs)
        {
            string[] result = item.Split(':');

            string city = result[1];
            string name = result[0];
            int amount = int.Parse(result[2]);
            if (!Cities.Contains(city))
            {
                Cities.Add(city);
            }
          Console.WriteLine(name + " " + amount);
        }
        



    }
}
