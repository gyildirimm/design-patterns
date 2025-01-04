namespace StrategyDesignPattern;

// 3. Context Sınıfı
public class ShoppingCart
{
    private IPaymentStrategy _paymentStrategy;
    
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }
    
    public void Checkout(decimal totalAmount)
    {
        if (_paymentStrategy is null)
        {
            Console.WriteLine("Lütfen bir ödeme yöntemi seçiniz!");
        }
        else
        {
            _paymentStrategy.Pay(totalAmount);
        }
    }
}