namespace Dependency_Inversion_Principle.Models;

internal class Bike : IVehicle

{
    /// <summary>
    /// this method is speific for bike maintenance
    /// </summary>
    public void PerformMaintenance()
    {
        Console.WriteLine("Perform Bike Maintenance");
    }
}
