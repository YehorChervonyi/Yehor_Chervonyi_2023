using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Motorcycle: Vehicle, IRidable
{
    public override void StartEngine()
    {
        Console.WriteLine("The engine is starting (Motorcycle)");
    }
    public void Ride()
    {
        Console.WriteLine("It's ride?");
    }
}