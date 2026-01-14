1)
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class Film
    {
    
        public string Title;
        public int Year;
        public string Genre;
        public string Description;
    
    
        public void PrintFilmInfo()
        {
    
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Описание: {Description}");
    
        }
    
        class Program
        {
            static void Main(string[] args)
            {
    
                Film film1 = new Film();
                film1.Title = "Жаркое соперничество";
                film1.Year = 2025;
                film1.Genre = "спорт";
                film1.Description = "Сериал о хоккеистах";
    
                Film film2 = new Film();
                film2.Title = "Очень странные дела";
                film2.Year = 2016;
                film2.Genre = "Фантастика, Ужасы, Драма";
                film2.Description = "Американский телесериал в жанре научной фантастики и ужасов";
    
    
    
                film1.PrintFilmInfo();
                film2.PrintFilmInfo();
    
            }
        }
    }

2)
  public class Student
  {
  
      public string Name { get; }
  
      private int _age;
      private int Age
      {
  
  
          get { return _age; }
  
          set
          {
              if (value < 0)
                  Console.WriteLine("Возраст не может быть отрицательным");
              _age = value;
          }
      }
  
      private double _gpa;
      public double GPA
      {
          get { return _gpa; }
          set
          {
              if (value < 0.0 || value > 4.0)
                  Console.WriteLine("GPA должен быть в диапазоне от 0.0 до 4.0");
              _gpa = value;
          }
      }


    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Студент: {Name}, Возраст: {Age}, GPA: {GPA:F2}");
    }
    class Program
    {
        static void Main()
        {



            Student student1 = new Student("Иван Иванов", 18, 3.7);
            Student student2 = new Student("Мария Петрова", 22, 3.9);
            Student student3 = new Student("Алексей Смирнов", 19, 2.8);


            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();


            student1.Age = 19;

            student2.GPA = 3.4;

            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();

        }

    }

}

3)
    public class Product
    {
    
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    
    
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    
    
        public double GetTotalCost()
        {
            return Price * Quantity;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Товар: {Name}");
            Console.WriteLine($"Цена за единицу: {Price:F2} руб.");
            Console.WriteLine($"Количество на складе: {Quantity} шт.");
            Console.WriteLine($"Общая стоимость: {GetTotalCost()} руб.");
        }
    
        class Program
        {
    
            static void Main(string[] args)
            {
                Product product1 = new Product("Ноутбук", 499779.9, 15);
                product1.DisplayInfo();
                Product product2 = new Product("Смартфон", 29999.5, 30);
                product2.DisplayInfo();
                double total = product1.GetTotalCost() + product2.GetTotalCost();
                Console.WriteLine($"все вместе: {total}");
            }
        }
    }

4)
      public class Rectangle
      {
      
          public int Width { get; set; }
          public int Height { get; set; }
      
      
          public Rectangle(int width, int height)
          {
              Width = width;
              Height = height;
          }
      
          public Rectangle() : this(1, 1) { }
      
      
          public Rectangle(int side) : this(side, side) { }
      
          public int GetArea()
          {
              return Width * Height;
          }
      
      
          public int GetPerimeter()
          {
              return 2 * (Width + Height);
          }
      
      
          public void DisplayInfo()
          {
              Console.WriteLine($"Прямоугольник {Width:F2} x {Height:F2}:");
              Console.WriteLine($"  Площадь: {GetArea():F2}");
              Console.WriteLine($"  Периметр: {GetPerimeter():F2}");
      
          }
      
      
      }
      class Program
      {
          static void Main()
          {
              Rectangle rect = new Rectangle(5, 3);
              Console.WriteLine("Прямоугольник :");
              rect.DisplayInfo();
      
      
      
          }
      }

5)
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; set; }
    
        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount("1111111111", 100000000);
            Console.WriteLine($"Счет: {account.AccountNumber}");
            Console.WriteLine($"Начальный баланс: {account.Balance} руб.");
    
            account.Deposit(500);
            Console.WriteLine($"После пополнения: {account.Balance} руб.");
    
            bool success = account.Withdraw(3000000);
            if (success)
                Console.WriteLine($"После снятия: {account.Balance} руб.");
            else
                Console.WriteLine("Недостаточно средств");
    
    
            success = account.Withdraw(2000000000000);
            if (success)
                Console.WriteLine($"После снятия: {account.Balance} руб.");
            else
                Console.WriteLine("Недостаточно средств для снятия 2000000000 руб.");
        }
    }
6)
      public class Computer
      {
          public string Model { get; set; }
          public int RAM { get; set; }
      
          public Computer(string model, int ram)
          {
              Model = model;
              RAM = ram;
          }
      
          public void DisplayInfo()
          {
              Console.WriteLine($"Модель: {Model}, ОЗУ: {RAM} ГБ");
          }
      }
      class Program
      {
          static void Main()
          {
      
              Computer[] computers = new Computer[]
              {
                  new Computer("Tecno pro", 16),
                  new Computer("Lenovo ThinkPad", 8),
                  new Computer("Apple MacBook Pro", 32),
                  new Computer("HP Pavilion", 12),
                  new Computer("Asus ROG", 64)
              };
      
              foreach (Computer comp in computers)
              {
                  comp.DisplayInfo();
              }
      
          }
      }
