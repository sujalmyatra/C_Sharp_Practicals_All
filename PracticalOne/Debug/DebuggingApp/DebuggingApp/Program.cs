using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter any name :: ");
        string? userResponse = Console.ReadLine();
        try
        {
            if (string.IsNullOrEmpty(userResponse))
            {
                Console.WriteLine("No input entered");
                return;
            }
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
