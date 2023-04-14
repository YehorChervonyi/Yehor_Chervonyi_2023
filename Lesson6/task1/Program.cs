using task1;
while (true)
{
    Console.Write("First number: ");
    float a = float.Parse(Console.ReadLine());
    Console.Write("Choose action (+, -, /, *): ");
    string userinput = Console.ReadLine();
    Console.Write("Second number: ");
    float b = float.Parse(Console.ReadLine());
    switch (userinput)
    {
        case "+":
            Opetations.DoOperation(a,b,Opetations.Add);
            break;
        case "-":
            Opetations.DoOperation(a,b,Opetations.Subtract);
            break;
        case "*":
            Opetations.DoOperation(a,b,Opetations.Multiply);
            break;
        case "/":
            Opetations.DoOperation(a,b,Opetations.Devide);
            break;
    }
}
