namespace Interface_Segregation_Principle.Models;

internal class OnlineOrder : IPaymentProcessor, IOnlineOrder
{
    /// <summary>
    /// this method will  be implemented from IPaymentProcessor and process payment
    /// </summary>
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Payment");
    }

    /// <summary>
    /// this method will be implemented from IOnlineOrder and generate receipt
    /// </summary>
    public void GenerateReceipt()
    {
        Console.WriteLine("Generating Receipt");

    }
}
