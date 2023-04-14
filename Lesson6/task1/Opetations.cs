namespace task1;

public class Opetations
{
    public delegate float Operation(float a, float b);
    public static void DoOperation(float a, float b, Operation operation)
    {
        Console.WriteLine(operation(a,b));
    }
    public static float Add (float a, float b ) => a + b;
    public static float Subtract (float a, float b ) => a - b;
    public static float Multiply (float a, float b ) => a * b;
    public static float Devide (float a, float b ) => a / b;
}