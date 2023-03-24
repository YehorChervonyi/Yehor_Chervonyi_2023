namespace task1.Classes.Details;

public class Cpu : Detail
{
    public string Socket { get; set; }
    public string Cores { get; set; }
    public string Frequency { get; set; }

    public Cpu
        (
            int price,
            string supplier,
            string country,
            string name,
            string socket,
            string cores,
            string frequency
            ): base(price, supplier, country, name)
    {
        Socket = socket;
        Cores = cores;
        Frequency = frequency;
    }
    
    public override string ShowInfo()
    {
        var baseInfo = base.ShowInfo();
        return $"--CPU--\n" +
               $"Socket: {Socket}\n" +
               $"Cores: {Cores}\n" +
               $"Frequency: {Frequency}\n" + baseInfo + "\n";
    }
        
    
}