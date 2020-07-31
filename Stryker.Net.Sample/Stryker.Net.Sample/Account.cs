using System;

namespace Stryker.Net.Sample
{
    public class Account
    {
        private readonly double _overdraftLimit = 500;
        
        public Guid Id { get; private set; }
        public string Owner { get; private set; }
        public double Balance { get; private set; }
        public bool Overdraft { get; private set; }

        public Account(string owner)
        {
            Id = Guid.NewGuid();
            Owner = owner;
        }

        public void EnableOverdraft()
        {
            Overdraft = true;
        }
        
        public void DisableOverdraft()
        {
            Overdraft = false;
        }
        
        public void AddMoney(double amount)
        {
            Balance += amount;
        }

        public void WithdrawMoney(double amount)
        {
            if (CanWithdraw(amount))
                Balance -= amount;
        }

        private bool CanWithdraw(double amount)
        {
            if (Overdraft)
                return (Balance + _overdraftLimit) > amount;
            
            return Balance > amount;
        }
    }
}