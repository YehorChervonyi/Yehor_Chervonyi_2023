using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Airplane : Vehicle, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("It's flying?");
    }
}