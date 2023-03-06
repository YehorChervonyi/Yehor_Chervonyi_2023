List<int> usernumbers = new List<int>();
int count = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Type {i + 1} number: ");
    usernumbers.Add(Convert.ToInt32(Console.ReadLine()));
}
for (int i = 0; i < 10; i++)
{
    count = 0;
   for (int j = i ; j < 10; j++)
    {
        if (usernumbers[i] == usernumbers[j])
        {
            count++;
        }
    }
   if (count > 1)
    {
        usernumbers.Add(usernumbers[i]);
    }
}

for (int i = 0; i < usernumbers.Count; i++)
{
    Console.WriteLine(usernumbers[i]);
}