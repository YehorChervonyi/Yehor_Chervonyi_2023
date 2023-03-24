namespace task1.Classes.Details;

public class Ram : Detail
{
    public string Type { get; set; }
    public string Size { get; set; }

    public Ram
        (
            int price,
            string supplier,
            string country,
            string name,
            string type,
            string size
            ): base(price, supplier, country, name)
    {
        Type = type;
        Size = size;
    }
    
    public override string ShowInfo()
    {
        var baseInfo = base.ShowInfo();
        return $"--RAM--\n" +
               $"Type: {Type}\n" +
               $"Size: {Size}\n" + baseInfo + "\n";
    }
}