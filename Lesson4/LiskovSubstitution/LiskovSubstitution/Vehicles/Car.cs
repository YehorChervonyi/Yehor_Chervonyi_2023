using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Car : Vehicle, IRidable
{
    public void Ride()
    {
        Console.WriteLine("It's ride?");
    }
}