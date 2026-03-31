using System;

namespace a
{  
    delegate decimal CheckCalculator(decimal price);

    class Program
    {
       
        static CheckCalculator CreateCalculator(decimal discountPercent)
        {
            return delegate (decimal price)
            {
                return price * (1 - discountPercent / 100);
            };
        }

        static void Main(string[] args)
        {
            CheckCalculator noviceCalculator = CreateCalculator(5);  
            CheckCalculator vipCalculator = CreateCalculator(20);     

            decimal price = 1000;

            Console.WriteLine($"Новичок: цена со скидкой = {noviceCalculator(price)}");
            Console.WriteLine($"VIP: цена со скидкой = {vipCalculator(price)}");
        }
    }
}
