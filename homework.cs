//1
using System;

class Seat
{
    public decimal Price { get; set; }
    public bool IsBooked { get; set; }
}

class CinemaHall
{
    public Seat[,] seats = new Seat[5, 10];

    public CinemaHall()
    {
        for (int row = 0; row < 5; row++)
        {
            decimal currentPrice = 500 - (row * 50);

            for (int col = 0; col < 10; col++)
            {
                seats[row, col] = new Seat();
                seats[row, col].Price = currentPrice;
                seats[row, col].IsBooked = false;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        CinemaHall hall = new CinemaHall();

        Console.WriteLine($"Цена на 1 ряду: {hall.seats[0, 0].Price} руб.");

        Console.WriteLine($"Цена на 5 ряду: {hall.seats[4, 0].Price} руб.");
    }
}
//2
using System;

class Program
{
    public struct Seat
    {
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            string status = IsBooked ? "Занято" : "Свободно";
            return $"Ряд {Row}, Место {SeatNumber} — Цена: {Price} руб. [{status}]";
        }
    }

    private static Seat[,] cinemaHall;

    public static void ShowAvailable(Predicate<Seat> filter)
    {
        if (cinemaHall == null) return;

        for (int i = 0; i < cinemaHall.GetLength(0); i++)
        {
            for (int j = 0; j < cinemaHall.GetLength(1); j++)
            {
                if (filter(cinemaHall[i, j]))
                {
                    Console.WriteLine(cinemaHall[i, j].ToString());
                }
            }
        }
    }

    static void Main()
    {
        cinemaHall = new Seat[3, 3];

        cinemaHall[0, 0] = new Seat { Row = 1, SeatNumber = 1, IsBooked = false, Price = 350 };
        cinemaHall[0, 1] = new Seat { Row = 1, SeatNumber = 2, IsBooked = true, Price = 350 }; // Занято
        cinemaHall[0, 2] = new Seat { Row = 1, SeatNumber = 3, IsBooked = false, Price = 350 };

        cinemaHall[1, 0] = new Seat { Row = 2, SeatNumber = 1, IsBooked = false, Price = 450 };
        cinemaHall[1, 1] = new Seat { Row = 2, SeatNumber = 2, IsBooked = false, Price = 450 };
        cinemaHall[1, 2] = new Seat { Row = 2, SeatNumber = 3, IsBooked = true, Price = 450 }; // Занято

        cinemaHall[2, 0] = new Seat { Row = 3, SeatNumber = 1, IsBooked = false, Price = 300 };
        cinemaHall[2, 1] = new Seat { Row = 3, SeatNumber = 2, IsBooked = true, Price = 500 }; // Занято
        cinemaHall[2, 2] = new Seat { Row = 3, SeatNumber = 3, IsBooked = false, Price = 300 };

        Console.WriteLine("весь зал");
        ShowAvailable(s => true);
        Console.WriteLine();

        Console.WriteLine("свободные места менье 400 руб");
        ShowAvailable(s => !s.IsBooked && s.Price < 400);
    }
}

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
