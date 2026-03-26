namespace Events.Models;

internal class Subscriber
{
    /// <summary>
    /// This is subscriber method, will be called when event occurs
    /// </summary>
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked");
    }
}
