using Events.Delegates;

namespace Events.Models;

public class ProcessBusinessLogic
{
    public event Notification? ProcessCompleted;

    /// <summary>
    /// Process starts from here
    /// </summary>
    public void StartProcess()
    {
       Console.WriteLine("Process Started!");
      
      OnProcessCompleted();
    }

    /// <summary>
    /// When event occures subscribermethod will invoked from this method
    /// </summary>
    protected virtual void OnProcessCompleted()
    {
        //Event Verification
        //if ProcessCompleted is not null then call delegate
        ProcessCompleted?.Invoke();
    }
}
