
List<Owner> owners = new List<Owner>()
{ 
    new Owner(1, "Tom", "Street1"),
    new Owner(2, "Bob", "Street2"),
    new Owner(3, "Jon", "Street3")
};

List<Car> cars = new List<Car>() 
{
    new Car ("KP1234KO", 1),
    new Car ("BA1234OH", 2),
    new Car ("AA1234KA", 3),
};

// Show all Car numbers
var showAllCars = from x in cars select x;
foreach (var car in showAllCars)
{
    Console.WriteLine(car.Number);
}

Console.Write("Enter car number: ");
string UserNumber = Console.ReadLine();

//Main task
var ownerByCarNumber = from x in owners from y in cars where y.Number == UserNumber where x.ID == y.OwnerId select x;
foreach (var owner in ownerByCarNumber)
{
    Console.WriteLine($"{owner.Name} - {owner.Address}");
}
class Owner
{
    public int ID { get; }
    public string Name { get; }
    public string Address { get; }
    public Owner(int id, string name, string address)
    {
        ID = id;
        Name = name;
        Address = address;
    }
}
class Car
{
    public string Number { get; }
    public int OwnerId { get; }
    public Car(string number, int ownerid) {
        Number = number;
        OwnerId = ownerid;
    }
}
