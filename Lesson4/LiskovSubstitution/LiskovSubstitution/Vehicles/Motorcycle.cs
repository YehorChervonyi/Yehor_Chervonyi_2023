using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Motorcycle: Vehicle, IRidable
{
    public void Ride()
    {
        Console.WriteLine("It's ride?");
    }
}