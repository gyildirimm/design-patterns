using StrategyDesignPattern;

var cart = new ShoppingCart();
decimal totalAmount = 1500m;

Console.WriteLine("Kredi Kartı Ödeme:");
cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(totalAmount);

Console.WriteLine("\nPayPal ile Ödeme:");
cart.SetPaymentStrategy(new PayPalPayment());
cart.Checkout(totalAmount);

Console.WriteLine("\nKripto Para ile Ödeme:");
cart.SetPaymentStrategy(new CryptoPayment());
cart.Checkout(totalAmount);