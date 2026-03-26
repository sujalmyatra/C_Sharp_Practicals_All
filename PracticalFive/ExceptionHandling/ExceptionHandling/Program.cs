
namespace ExceptionHandling;

public class Program
{
    /// <summary>
    /// this program goes until all elements of array and after that will throw exception 
    /// if tried to access non-exist element of array
    /// </summary>
    public static void Main()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        try
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine($"Index::{i} Value::{arr[i]}");
            }
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message); 
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("This is finally block");
        }
    }
}