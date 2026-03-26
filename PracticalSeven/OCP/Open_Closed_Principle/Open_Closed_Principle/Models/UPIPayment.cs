namespace Open_Closed_Principle.Models;

internal class UPIPayment : IPaymentProcessor
{
    /// <summary>
    /// this method will implement UPI payment process
    /// </summary>
    /// <param name="amount"></param>
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing UPI payment for amount: ${amount}");
    }
}
