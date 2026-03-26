namespace Interface_Segregation_Principle;
class Program
{
    public static void Main()
    {
        Console.WriteLine("InHouseOrder:");
        var inHouseOrder = new InHouseOrder();
        inHouseOrder.PrintTicket();

        Console.WriteLine("\nOnlineOrder:");
        var onlineOrder = new OnlineOrder();
        onlineOrder.ProcessPayment();
        onlineOrder.GenerateReceipt();

    }
}