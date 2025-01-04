namespace StrategyDesignPattern;

// 2. Concrete Strategy (Ödeme Yöntemleri)
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Kredi Kartı ile {amount} TL ödendi.");
    }
}