using Inheritance.Models;

namespace Inheritance;
public class Program
{
    public static void Main()
    {
        Team team = new Team("Ambani","Mumbai Indians");
        Console.WriteLine(team.PrintInfo());
    }
}