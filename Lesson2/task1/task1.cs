Random rnd = new Random();
List<Products> products = new List<Products>()
{
    new Products("Product1",rnd.Next(1,1000)),
    new Products("Product2",rnd.Next(1,1000)),
    new Products("Product3",rnd.Next(1,1000)),
    new Products("Product4",rnd.Next(1,1000)),
    new Products("Product5",rnd.Next(1,1000)),
    new Products("Product6",rnd.Next(1, 1000)),
    new Products("Product7",rnd.Next(1, 1000)),
    new Products("Product8",rnd.Next(1, 1000)),
    new Products("Product9",rnd.Next(1, 1000)),
    new Products("Product10",rnd.Next(1, 1000)),
};

var Sort = products.OrderBy(x => x.Price);

Console.WriteLine("Ascending sorting");
foreach (var product in Sort)
{   
    Console.WriteLine($"{product.Name} : {product.Price}");
}

Console.WriteLine("--------------------");

Console.WriteLine("Descending sorting");
foreach (var product in Sort.Reverse())
{
    Console.WriteLine($"{product.Name} : {product.Price}");
}

class Products
{
    public string Name { get; }
    public int Price { get; }
    public Products(string name, int price)
    {
        Name = name;
        Price = price;
    }
}