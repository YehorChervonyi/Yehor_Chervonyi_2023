namespace task1.Classes.Details;

public class Gpu : Detail
{
    public string Memory { get; set; }
    public string Speed { get; set; }

    public Gpu
        (
            int price,
            string supplier,
            string country,
            string name,
            string memory,
            string speed
            ): base(price, supplier, country, name)
    {
        Memory = memory;
        Speed = speed;
    }
    public override string ShowInfo()
    {
        var baseInfo = base.ShowInfo();
        return $"--GPU--\n" +
               $"Memory: {Memory}\n" +
               $"Speed: {Speed}\n" + baseInfo + "\n";
    }
    
}