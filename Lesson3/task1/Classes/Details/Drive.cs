namespace task1.Classes.Details;

public class Drive : Detail
{
    public string Size { get; set; }
    public string Type { get; set; }
    public string ConnectInterface { get; set; }
    public string Speed { get; set; }
    public string? Lifetime { get; set; }

    public Drive
        (
            int price,
            string supplier,
            string country,
            string name,
            string size,
            string type,
            string connectInterface,
            string speed,
            string? lifetime
            ): base(price, supplier, country, name)
    {
        Size = size;
        Type = type;
        ConnectInterface = connectInterface;
        Speed = speed;
        Lifetime = lifetime;

    }
    public override string ShowInfo()
    {
        if (Type == "HDD")
        {
            var baseInfo = base.ShowInfo();
            return $"--Drive--\n" +
                   $"Size: {Size}\n" +
                   $"Type: {Type}" +
                   $"Connection Interface: {ConnectInterface}\n" +
                   $"Speed: {Speed}\n" + baseInfo + "\n";
        }
        else
        {
            var baseInfo = base.ShowInfo();
            return $"--Drive--\n" +
                   $"Size: {Size}\n" +
                   $"Type: {Type}\n" +
                   $"Connection Interface: {ConnectInterface}\n" +
                   $"Speed: {Speed}\n" +
                   $"Lifetime: {Lifetime}\n" + baseInfo + "\n";    
        }
        
    }
}