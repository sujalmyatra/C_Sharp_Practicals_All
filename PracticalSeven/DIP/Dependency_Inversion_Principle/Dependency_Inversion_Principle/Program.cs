
namespace Dependency_Inversion_Principle;
class Program
{
    public static void Main()
    {
        var car = new Car();
        var maintainService = new MaintenanceService(car);
        maintainService.MaintainVehicle();

        var bike = new Bike();
        maintainService = new MaintenanceService(bike);
        maintainService.MaintainVehicle();

        var truck = new Truck();
        maintainService = new MaintenanceService(truck);
        maintainService.MaintainVehicle();


    }
}