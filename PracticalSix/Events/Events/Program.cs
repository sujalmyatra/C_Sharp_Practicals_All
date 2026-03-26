using Events.Models;

namespace Events;

public class Program
{
    public static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += Subscriber.bl_ProcessCompleted;
        bl.StartProcess();
    }
    
}