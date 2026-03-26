namespace CustomerAccouunt.Models;

internal class CustomerAccount
{
    private string _customerName;
    private long _customerAccountNo;
    public string BankName = String.Empty;
   

    public CustomerAccount(string customerName, long accountNo)
    { 
        _customerName = customerName;
        _customerAccountNo = accountNo;
    }

    /// <summary>
    /// purpose :: to print all the detailes of customer account
    /// return type :: void means it does not return anything
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine($"Bank Name :: {BankName}");
        Console.WriteLine($"Customer Name :: {_customerName}");
        Console.WriteLine($"Customer Acc. No. :: {_customerAccountNo}");

    }
}
