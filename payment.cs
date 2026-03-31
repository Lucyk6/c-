using System;

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}
public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата банковской картой: {amount} рублей. ");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата через PayPal: {amount} рублей.");
        Console.WriteLine("Оплата через PayPal успешно завершена.");
    }
}

public class CryptoPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата криптовалютой: {amount} рублей.");
        Console.WriteLine("Криптовалютная оплата успешно завершена.");
    }
}
public class PaymentProcessor
{
    public void MakePayment(IPaymentMethod paymentMethod, decimal amount)
    {
        paymentMethod.ProcessPayment(amount);
    }
}

class Program
{
    static void Main()
    {
        IPaymentMethod creditCard = new CreditCardPayment();
        IPaymentMethod payPal = new PayPalPayment();
        IPaymentMethod crypto = new CryptoPayment();

        PaymentProcessor processor = new PaymentProcessor();

        decimal amount = 1000m; 

        Console.WriteLine("Оплата банковской картой:");
        processor.MakePayment(creditCard, amount);

        Console.WriteLine("Оплата через PayPal:");
        processor.MakePayment(payPal, amount);

        Console.WriteLine("Оплата криптовалютой:");
        processor.MakePayment(crypto, amount);
    }
}
