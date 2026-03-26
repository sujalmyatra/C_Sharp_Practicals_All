using CustomerAccouunt.Models;

namespace CustomerAccouunt;
public class Program
{
    public static void Main()
    {

        CustomerAccount holder = new CustomerAccount("ABC", 12345);
        holder.BankName = "SBI";

        holder.PrintInfo();
    }
}