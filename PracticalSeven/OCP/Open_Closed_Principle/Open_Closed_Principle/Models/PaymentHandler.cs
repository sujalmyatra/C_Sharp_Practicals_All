namespace Open_Closed_Principle.Models;

internal class PaymentHandler
{
    private readonly IPaymentProcessor _paymentProcessor;

    /// <summary>
    /// this constructor will take IPaymentProcessor reference
    /// </summary>
    /// <param name="paymentProcessor"></param>
    public PaymentHandler(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    /// <summary>
    /// This method will use IPaymentProcessor reference and call the specific reference ProcessPayment method
    /// </summary>
    /// <param name="amount"></param>
    public void ExecutePayment(double amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}
