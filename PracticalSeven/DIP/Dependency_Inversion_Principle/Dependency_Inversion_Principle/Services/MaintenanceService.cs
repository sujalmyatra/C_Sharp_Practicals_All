
namespace Dependency_Inversion_Principle.Services;

internal class MaintenanceService
{
    private readonly IVehicle _vehicle;
    public MaintenanceService(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    /// <summary>
    /// this method will use reference of IVehicle and implements PerformMaintenance
    /// </summary>
    public void MaintainVehicle()
    {
        _vehicle.PerformMaintenance();
    }

    
}
