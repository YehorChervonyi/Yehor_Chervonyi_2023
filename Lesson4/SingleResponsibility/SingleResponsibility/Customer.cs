namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        
        public Customer(int id, string name, decimal balance)
        {
            Id = id; 
            Name = name; 
            Balance = balance;
        }

        public string GetBalanceById(List<Customer> list, int id)
        {
            return $"Your balance is: {GetCustomerById(list, id).Balance}";
        }
        public Customer GetCustomerById(List<Customer> list, int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }
        public string SaveToDatabase()
        {
            return "Saved!";
        }
        public void UpdateBalance(List<Customer> list, int id, decimal newBalance)
        {
            GetCustomerById(list, id).Balance = newBalance;
            SaveToDatabase();
        }
    }
}