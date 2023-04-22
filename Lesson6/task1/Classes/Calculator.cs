using task1;

public class Calculator
{
    public void CalculatorMain()
    {
        Opetations operation = new Opetations();
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
}
