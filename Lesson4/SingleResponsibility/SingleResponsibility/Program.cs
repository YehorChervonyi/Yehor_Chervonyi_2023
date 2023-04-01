using SingleResponsibility;
List<Customer> CustomersList = new List<Customer>()
{
    new Customer(1, "Fikus", 0),
    new Customer(2, "VHarbar", 100000)
};

foreach (var customer in CustomersList)
{
    Console.Write($"{customer.Name} {customer.GetBalanceById(CustomersList, customer.Id)}\n");
}
