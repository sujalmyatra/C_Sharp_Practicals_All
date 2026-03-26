using Polymorphism.Models;

namespace Polymorphism;
public class Program
{
    public static void Main()
    {
        Bird myBird = new Bird();
        Bird myDuck = new Duck();
        myBird.Voice();
        myDuck.Voice();
    }

}