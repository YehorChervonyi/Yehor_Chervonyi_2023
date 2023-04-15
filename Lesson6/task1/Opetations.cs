namespace task1;
public class Opetations
{
    public delegate float Operation(float a, float b);
    public delegate void OperationHandler(string message);
    public event OperationHandler? Notify;
    public float Add (float a, float b ) => a + b;
    public float Subtract (float a, float b ) => a - b;
    public float Multiply (float a, float b ) => a * b;
    public float Devide (float a, float b ) => a / b;
    
    void displayMessage(string message) => Console.WriteLine(message);
    
    public void DoOperation(float a, float b, Operation operation)
    {
        Notify = displayMessage;
        Notify.Invoke($"Result: {operation(a,b)}");
    }
}