namespace task1.Classes;

public class Detail
{
    public int Price { get; set; }
    public string Supplier { get; set; }
    public string Country { get; set; }
    public string Name { get; set; }
    public Detail(int price, string supplier, string country, string name)
    {
        Price = price;
        Supplier = supplier;
        Country = country;
        Name = name;
    }
    public virtual string ShowInfo()
    {
        return $"Price: {Price}\n" +
               $"Supplier: {Supplier}\n" +
               $"Country: {Country}\n" +
               $"Name: {Name}\n";
    }
}