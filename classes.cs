using System;
class Book {
    public string Title;

    public string Author;

    public int Year;
  
    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестно";
        Year = 2000;
    }

   
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"Year: {Year}, Author: {Author}, The title{Title}"); 
    }

    public void IsOld ()
    {
    
        if(Year<2006)
        {
            Console.WriteLine("It is old book");

        }
        else if (Year > 2026)
        {
            Console.WriteLine("Error");

        }
        
    }
}
class Program
{
    static void main()
    {

        Book b1 = new Book();
        Book b2 = new Book("Война и мир", "Лев Толстой", 1869);
        Book b3 = new Book
        {
            Title = "Мастер и Маргарита",
            Author = "Михаил Булгаков",
            Year = 1967

        };
        b1.PrintInfo();
        b1.IsOld();
        b2.PrintInfo();
        b2.IsOld();
        b3.PrintInfo();
        b3.IsOld();

    }
}
