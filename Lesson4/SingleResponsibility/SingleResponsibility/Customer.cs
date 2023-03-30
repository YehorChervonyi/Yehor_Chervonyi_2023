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
        
        public string GetBalance(int id)
        {
            return $"Your balance is: {Balance}";
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalance(decimal newBalance)
        {
            this.Balance = newBalance;
            SaveToDatabase();
        }
    }
}