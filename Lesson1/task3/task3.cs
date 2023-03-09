List<int> usernumbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Type {i + 1} number: ");
    usernumbers.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.Write("Enter number to dublicate in list: ");
int dubnumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    if (usernumbers[i] == dubnumber)
    {
        usernumbers.Add(dubnumber);
    }
}

for (int i = 0; i < usernumbers.Count; i++)
{
    Console.WriteLine(usernumbers[i]);
}