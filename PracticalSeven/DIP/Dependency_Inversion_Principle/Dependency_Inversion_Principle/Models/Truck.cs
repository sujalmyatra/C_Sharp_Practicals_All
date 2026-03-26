namespace Dependency_Inversion_Principle.Models;

internal class Truck : IVehicle
{
    /// <summary>
    /// this method is speific for truck maintenance
    /// </summary>
    public void PerformMaintenance()
    {
        Console.WriteLine("Perform Truck Maintenance");
    }
}
