using Calculator.Models;

namespace Calculator;
public class Program
{
    public static void Main()
    {
        double numOne;
        double numTwo;

        Console.Write("Enter First Number :: ");
        if (!double.TryParse(Console.ReadLine(), out numOne))
        {
            Console.WriteLine("Invalid First Number!!");
            return;
        }

        Console.Write("\nEnter Second Number :: ");
        if (!double.TryParse(Console.ReadLine(), out numTwo))
        {
            Console.WriteLine("Invalid Second Number!!");
            return;
        }

        Display(numOne, numTwo);
    }

    /// <summary>
    /// To display All operations and print answers takes two inputs 
    /// </summary>
    /// <param name="numOne"></param>
    /// <param name="numTwo"></param>
    public static void Display(double numOne, double numTwo)
    {
        Console.WriteLine($"The sum of the {numOne} and {numTwo} is {ArithmaticOperation.Addition(numOne, numTwo)}");
        Console.WriteLine($"The subtraction of the {numOne} and {numTwo} is {ArithmaticOperation.Subtraction(numOne, numTwo)}");
        Console.WriteLine($"The multiplication of the {numOne} and {numTwo} is {ArithmaticOperation.Multiplication(numOne, numTwo)}");
        try
        {
            Console.WriteLine($"The division of the {numOne} and {numTwo} is {ArithmaticOperation.Division(numOne, numTwo)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}