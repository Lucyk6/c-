using System;
class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }
    public BankAccount( double initialBalance = 0)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Пополнение на {amount:C}. Новый баланс: {balance:C}");
        }
        else
        {
            Console.WriteLine("Сумма пополнения должна быть положительной.");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount < balance)
        {
            Console.WriteLine("Недостаточно средств");
        }
        else
        {
            Console.WriteLine(balance - amount);
            Console.WriteLine($"Снятие {amount}. Новый баланс: {balance}");
        }


    }
}
class Program
{
    static void main()
    {
        BankAccount account = new BankAccount(497548);
        Console.WriteLine($"Начальный баланс: {account.Balance:C}");

        account.Deposit(200);
        account.Withdraw(100);
        account.Withdraw(50000000000); 
        Console.WriteLine($"Итоговый баланс: {account.Balance:C}");



    }


}
    
