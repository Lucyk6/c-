using System;
using System.Collections.Generic;

namespace CinemaMatrix
{
    // 1. Простые структуры данных
    public class Seat
    {
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }

        public Seat(decimal price)
        {
            Price = price;
            IsBooked = false; 
        }
    }

    public class CinemaHall
    {
        public Seat[,] seats = new Seat[5, 10];

        public event Action OnHallFull; 
        public Action<string> History; 

        public CinemaHall()
        {
            for (int r = 0; r < 5; r++)
            {
                decimal rowPrice = (r < 2) ? 500  : 350;

                for (int c = 0; c < 10; c++)
                {
                    seats[r, c] = new Seat(rowPrice);
                }
            }
        }

        public void ShowAvailable(Predicate<Seat> filter)
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    
                    if (filter(seats[r, c]))
                    {
                        Console.WriteLine($"Ряд {r + 1}, Место {c + 1} — {seats[r, c].Price} руб.");
                    }
                }
            }
        }

        public bool TryBook(int row, int col, Func<int, int, decimal, decimal> priceModifier)
        {
            if (row < 1 || row > 5 || col < 1 || col > 10)
            {
                History?.Invoke($"Ошибка: Ряд {row} не существует");
                return false;
            }
            int rIdx = row - 1;
            int cIdx = col - 1;

            Seat currentSeat = seats[rIdx, cIdx];

            if (currentSeat.IsBooked)
            {
                History?.Invoke($"Ошибка: Ряд {row}, Место {col} уже занято");
                return false;
            }

            decimal finalPrice = priceModifier(row, col, currentSeat.Price);

            currentSeat.IsBooked = true;

            History?.Invoke($"Ряд {row}, Место {col} забронировано за {finalPrice} руб.");

            if (CheckIfFull())
            {
                OnHallFull?.Invoke(); 
            }

            return true;
        }

        private bool CheckIfFull()
        {
            foreach (var seat in seats)
            {
                if (!seat.IsBooked) return false; 
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CinemaHall hall = new CinemaHall();
            List<string> log = new List<string>();

            hall.History = (message) => log.Add(message);

            hall.OnHallFull += () => Console.WriteLine("\n[Событие] Свободных мест больше нет!");

            hall.seats[0, 0].IsBooked = true; 

            hall.ShowAvailable(s => !s.IsBooked);

            hall.ShowAvailable(s => !s.IsBooked && s.Price < 400);

            Func<int, int, decimal, decimal> myModifier = (row, col, basePrice) =>
            {
                if (row == 5) return basePrice * 1.2m;      
                if (col >= 1 && col <= 3) return basePrice * 0.9m; 
                return basePrice;                        
            };

            hall.TryBook(5, 5, myModifier); 
            hall.TryBook(3, 2, myModifier);  
            hall.TryBook(10, 2, myModifier); 


            foreach (string line in log)
            {
                Console.WriteLine(line);
            }
        }
    }
}
