namespace SingleResponsibility;

public class CustomerServise
{
    public List<Customer> CustomersList = new List<Customer>()
    {
        new Customer(1, "Fikus", 0),
        new Customer(2, "VHarbar", 100000)
    };

    public void GetBalance(int id)
    {
        Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
    }
    public decimal GetBalanceById(int id)
    {
        var customer = CustomersList.FirstOrDefault(x => x.Id == id);
        return customer.Balance;
    }
    public Customer GetById(int id)
    {
        return CustomersList.FirstOrDefault(x => x.Id == id);
    }
    public void UpdateBalance(int id, decimal newBalance)
    {
        var customer = GetById(id);
        customer.Balance = newBalance;
    }
}