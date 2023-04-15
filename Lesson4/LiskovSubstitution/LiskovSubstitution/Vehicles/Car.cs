using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Car : Vehicle, IRidable
{
    public override void StartEngine()
    {
        Console.WriteLine("The engine is starting (Car)");
    }
    public void Ride()
    {
        Console.WriteLine("It's ride?");
    }
}