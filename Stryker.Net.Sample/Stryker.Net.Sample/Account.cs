using System;

namespace Stryker.Net.Sample
{
    public class Account
    {
        private double _overdraftLimit = 500;
        
        public Guid Id { get; private set; }
        public string Owner { get; private set; }
        public double Balance { get; private set; }
        public bool Overdraft { get; private set; }

        public Account(string owner, bool overdraft)
        {
            Id = Guid.NewGuid();
            Owner = owner;
            Balance = 0;
            Overdraft = overdraft;
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