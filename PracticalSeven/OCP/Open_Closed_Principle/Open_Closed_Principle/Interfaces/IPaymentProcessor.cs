namespace Open_Closed_Principle.Interfaces;

internal interface IPaymentProcessor
{
    /// <summary>
    /// this is an abstract method to be implemented for payment processing
    /// </summary>
    /// <param name="amount"></param>
    void ProcessPayment(double amount);
}
