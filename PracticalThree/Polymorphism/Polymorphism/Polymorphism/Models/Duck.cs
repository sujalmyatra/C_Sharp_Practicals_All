namespace Polymorphism.Models;

internal class Duck : Bird
{
    /// <summary>
    /// This method overrides from Bird
    /// </summary>
    public override void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}
