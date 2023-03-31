﻿namespace SingleResponsibility
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

        public List<Customer> CustomersList = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };

        public void GetBalanceById(int id)
        {
            Console.WriteLine($"Your balance is: {GetCustomerById(id).Balance}");
        }
        public Customer GetCustomerById(int id)
        {
            return CustomersList.FirstOrDefault(x => x.Id == id);
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalance(int id, decimal newBalance)
        {
            GetCustomerById(id).Balance = newBalance;
            SaveToDatabase();
        }
    }
}