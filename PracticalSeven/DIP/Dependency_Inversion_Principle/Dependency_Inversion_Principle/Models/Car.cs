namespace Dependency_Inversion_Principle.Models;

internal class Car : IVehicle
{
    /// <summary>
    /// this method is speific for car maintenance
    /// </summary>
    public void PerformMaintenance()
    {
        Console.WriteLine("Perform Car Maintenance");
    }
}
