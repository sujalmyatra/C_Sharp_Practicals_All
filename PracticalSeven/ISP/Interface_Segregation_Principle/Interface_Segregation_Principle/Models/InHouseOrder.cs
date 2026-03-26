namespace Interface_Segregation_Principle.Models;

internal class InHouseOrder : IInHouseOrder
{
    /// <summary>
    /// this method will implemented from IInHouseOrder print ticket
    /// </summary>
    public void PrintTicket()
    {
        Console.WriteLine("Printing Ticket!!");
    }
}
