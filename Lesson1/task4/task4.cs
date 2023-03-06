Console.Write("Type first string: ");
string userinput1 = Console.ReadLine();
Console.Write("Type second string: ");
string userinput2 = Console.ReadLine();
if (userinput1.Length > userinput2.Length)
{
    Console.WriteLine(userinput2 + userinput1);
}
else if (userinput2.Length > userinput1.Length && userinput1.Length != userinput2.Length)
{
    string[] userinput2split = userinput2.Split(userinput1[0]);
    foreach (string element in userinput2split)
    {
        Console.Write(element+" ");
    }
}