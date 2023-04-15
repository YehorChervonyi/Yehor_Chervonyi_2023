using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Airplane : Vehicle, IFlyable
{
    public override void StartEngine()
    {
        Console.WriteLine("The engine is starting (Airplane)");
    }
    
    public void Fly()
    {
        Console.WriteLine("It's flying?");
    }
}