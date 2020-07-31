namespace Stryker.Net.Sample.Tests
{
    public class AccountBuilder
    {
        private string _owner = "Mark";
        private bool _overdraft;
        private double _amount;
        
        public Account Build()
        {
            var account = new Account(_owner);

            if (_amount != default)
                account.AddMoney(_amount);
            
            if (_overdraft != default)
                account.EnableOverdraft();
            
            return account;
        }
        
        public AccountBuilder WithOverdraft()
        {
            _overdraft = true;
            return this;
        }

        public AccountBuilder WithInitialAmount(double value)
        {
            _amount = value;
            return this;
        }
    }
}