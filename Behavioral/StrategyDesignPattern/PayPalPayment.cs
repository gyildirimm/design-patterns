namespace StrategyDesignPattern;

// 2. Concrete Strategy (Ödeme Yöntemleri)
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"PayPal üzerinden {amount} TL ödendi.");
    }
}