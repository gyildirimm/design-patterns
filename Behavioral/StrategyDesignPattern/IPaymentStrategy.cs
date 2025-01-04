namespace StrategyDesignPattern;

// 1. Strategy Arayüzü
public interface IPaymentStrategy
{
    public void Pay(decimal amount);
}