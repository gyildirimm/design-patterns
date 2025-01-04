namespace StrategyDesignPattern;

// 2. Concrete Strategy (Ödeme Yöntemleri)
public class CryptoPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Kripto Para ile {amount} TL ödendi.");
    }
}