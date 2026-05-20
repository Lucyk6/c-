namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> telemphone = new Dictionary<string, string>(10)
            {
                ["Liza"] = "+714634564",
                ["Maxim"] = "+791456565",
                ["Lusine"] = "+785659879"
            };
            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1: Добавить контакт");
                Console.WriteLine("2: перезаписать");
                Console.WriteLine("3: Удалить контакт");
                Console.WriteLine("4: найти контакт");
                Console.WriteLine("5: Показать все контакт");

               int result=Convert.ToInt32(Console.ReadLine());



            }
          
        }
    }
}
