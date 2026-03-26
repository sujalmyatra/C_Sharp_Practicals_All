using Switching.Enums;
using Switching.Models;

namespace Switching;

public class Program
{
    public static void Main()
    {

        Student student = new Student("ABC");
        Console.WriteLine($"Enter Marks of {student.Name}");
        for(int i = 0; i < student.Marks.Length; i++)
        {
            if (decimal.TryParse(Console.ReadLine(),out decimal mark)){
                student.Marks[i] = mark;
            }
            else
            {
                Console.WriteLine("Enter Valid Marks");
                return;
            }
        }

        student.CalculateAverageMarks();

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("1 - Aggregate: Displays the Name: Average marks");
            Console.WriteLine("2 - MinMark: Displays the minimum marks of the student");
            Console.WriteLine("3 - MaximumMark: Displays the maximum mark");
            Console.WriteLine("4 - Grade: Displays grade");
            Console.WriteLine("5 - EXIT");

            if (int.TryParse(Console.ReadLine(), out int digit))
            {
                switch (digit)
                {
                    case (int)Options.Aggregate:
                        Console.WriteLine($"Name :: {student.Name} : {student.CalculateAverageMarks()}");
                        break;
                    case (int)Options.MinMark:
                        Console.WriteLine($"Name(Minimum) :: {student.Name} : {student.CalculateMin()}");
                        break;
                    case (int)Options.MaximumMark:
                        Console.WriteLine($"Name(Maximum) :: {student.Name} : {student.CalculateMax()}");
                        break;
                    case (int)Options.Grade:
                        Console.WriteLine($"Name(Grade) :: {student.Name} : {student.CalculateGrade(Student.AverageMarks)}");
                        break;
                    case (int)Options.Exit:
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Option Choosen");
                        break;

                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}