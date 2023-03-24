namespace task1.Classes.Details;

public class Motherboard : Detail
{
    public string Socket { get; set; }
    public int CpuSlots { get; set; }
    public int SlotsCount { get; set; }
    public string RamSupport { get; set; }
    public int PcieSlots { get; set; }
    public Dictionary<string, int> ConnectInterface { get; set; } = new Dictionary<string, int>();

    public Motherboard
        (
            int price,
            string supplier,
            string country,
            string name,
            string socket,
            int cpuSlots,
            int slotsCount,
            string ramSupport,
            int pcieSlots,
            Dictionary<string,int> connectInterface
                ):base (price, supplier, country, name)
    {
        Socket = socket;
        CpuSlots = cpuSlots;
        SlotsCount = slotsCount;
        RamSupport = ramSupport;
        PcieSlots = pcieSlots;
        ConnectInterface = connectInterface;

    }
    
    public override string ShowInfo()
    {
        var baseInfo = base.ShowInfo();
        string result = "";
        var allInterfaces = from x in ConnectInterface select x;
        result += $"--Motherboard--\n" +
               $"Socket: {Socket}\n" +
               $"CPU slots ammount {CpuSlots}\n" +
               $"DDR slots ammount: {SlotsCount}\n" +
               $"Ram support: {RamSupport}\n" +
               $"PCI-E slots: {PcieSlots}\n";
        foreach (var interfaces in allInterfaces)
        {
            result += $"Interface: {interfaces.Key} | {interfaces.Value} can be use\n";
        }

        return result + baseInfo + "\n";
    }
}