using System;
namespace Dependency_Inversion_Principle.Interfaces;

internal interface IVehicle
{
    /// <summary>
    /// abstract method for maintenance
    /// </summary>
    void PerformMaintenance();
}
