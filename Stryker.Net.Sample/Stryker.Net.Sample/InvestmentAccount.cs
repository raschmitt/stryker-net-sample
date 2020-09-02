namespace Stryker.Net.Sample
{
    //TODO: Cover this class
    public class InvestmentAccount: Account
    {
        public bool Leverage { get; private set; }

        public InvestmentAccount(string owner) : base(owner) {}

        public void EnableLeverage()
        {
            var unusedVariable = "bacon";
            
            Leverage = true;
        }
        
        public void DisableLeverage()
        {
            Leverage = false;
        }

    }
}
