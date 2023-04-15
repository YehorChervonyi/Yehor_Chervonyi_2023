using LiskovSubstitution.Vehicles;

Vehicle veh = new Vehicle();
Vehicle moto = new Motorcycle();
Vehicle car = new Car();
Vehicle airplane = new Airplane();

List<Vehicle> list = new List<Vehicle>()
{
    new Vehicle(),
    new Motorcycle(),
    new Car(),
    new Airplane()
};

foreach (var vehicle in list)
{
    vehicle.PerformActions(vehicle);
}








