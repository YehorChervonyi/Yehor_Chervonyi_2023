Random rnd = new Random();
List<Person> people = new List<Person>()
{
    new Person ("Tom",rnd.Next(1,90)),
    new Person ("Sam",rnd.Next(1,90)),
    new Person ("Bob",rnd.Next(1,90)),
    new Person ("Ban",rnd.Next(1,90))
};
 // Show all Persons
var showall = from x in people select x;
foreach (var person in showall)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}
// Ask for ages
Console.Write("Write age to start with: ");
int startage = Convert.ToInt32(Console.ReadLine());

Console.Write("Write age to end with: ");
int endage = Convert.ToInt32(Console.ReadLine());

// Main task
var filter = from x in people where x.Age >= startage && x.Age <= endage select x;
foreach(var person in filter)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}
class Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}