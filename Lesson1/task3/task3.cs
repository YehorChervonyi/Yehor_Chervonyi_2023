List<int> usernumbers = new List<int>();
for (int i = 0; i < 10; i++)
{
    Console.Write($"Type {i + 1} number: ");
    usernumbers.Add(int.Parse(Console.ReadLine()));
}
foreach (int i in usernumbers)
{
    Console.WriteLine($"{i}");
}