Random rnd = new Random();
List<Customer> customers = new List<Customer>()
{
    new Customer("Tom", rnd.Next(1,90),"Street1"),
    new Customer("Tim", rnd.Next(1,90),"Street2"),
    new Customer("Leo", rnd.Next(1,90),"Street3"),
    new Customer("Tom", rnd.Next(1,90),"Street4"),
    new Customer("Jon", rnd.Next(1,90),"Street5"),
    new Customer("Max", rnd.Next(1,90),"Street6"),
    new Customer("Bob", rnd.Next(1,90),"Street7"),
    new Customer("Ban", rnd.Next(1,90),"Street8"),
    new Customer("Van", rnd.Next(1,90),"Street9"),
    new Customer("Sam", rnd.Next(1,90),"Street10")
};
// Show all Customers
var showall = from x in customers select x;
foreach (var customer in showall)
{
    Console.WriteLine($"{customer.Name} - {customer.Age} - {customer.Address}");
}

// User input
Console.Write("Enter customer name: ");
string userInputName = Console.ReadLine();

// Main task
int countOldCustomers = 0;
var filterdByAgeName = from x in customers where x.Name == userInputName select x;
foreach(var customer in filterdByAgeName)
{
    Console.WriteLine($"{customer.Name} - {customer.Age} - {customer.Address}");
    if(customer.Age > 18)
    {
        countOldCustomers++;
    }
}
Console.WriteLine($"Customers older 18 y.o. : {countOldCustomers}");

class Customer
{
    public string Name;
    public int Age;
    public string Address;
    public Customer(string name, int age, string address) { 
        Name = name;
        Age = age;
        Address = address;
    }
}