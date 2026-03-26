
using Abstraction.Models;

namespace Abstraction;
public class Program
{
    public static void Main()
    {
        Laptop device = new Laptop();

        device.Brand = "DELL";
        device.Model = "Legion I7";

        device.LaptopDetails();
        ///this MotherBoardInfo Method can not be accessed because it is private
        device.MotherBoardInfo();
    }
}