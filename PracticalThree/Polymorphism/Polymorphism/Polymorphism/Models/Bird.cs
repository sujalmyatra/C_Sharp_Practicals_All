namespace Polymorphism.Models;

internal class Bird
{
    /// <summary>
    /// This method will overrided By Duck
    /// </summary>
    public virtual void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}
