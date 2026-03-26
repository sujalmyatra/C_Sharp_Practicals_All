namespace Open_Closed_Principle;
class Program
{
    public static void Main()
    {
        var creditCard = new CreditCardPayment();
        var paymentHandler = new PaymentHandler(creditCard);
        paymentHandler.ExecutePayment(1000.60);

        var UPICode = new UPIPayment();
        paymentHandler = new PaymentHandler(UPICode);
        paymentHandler.ExecutePayment(5000.50);
    }
}