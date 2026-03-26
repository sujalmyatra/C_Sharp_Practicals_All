namespace Open_Closed_Principle.Models;

internal class CreditCardPayment : IPaymentProcessor
{
    /// <summary>
    /// this method will implement CreditCard payment process
    /// </summary>
    /// <param name="amount"></param>
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment for amount: ${amount}");
    }

}
