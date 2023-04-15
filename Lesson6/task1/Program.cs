using task1;

Opetations operation = new Opetations();
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
            operation.DoOperation(a,b,operation.Add);
            break;
        case "-":
            operation.DoOperation(a,b,operation.Subtract);
            break;
        case "*":
            operation.DoOperation(a,b,operation.Multiply);
            break;
        case "/":
            operation.DoOperation(a,b,operation.Devide);
            break;
    }
}
