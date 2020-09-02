namespace Stryker.Net.Sample
{
    //ToDo: Cover this class
    public class InvestmentAccount: Account
    {
        public bool Leverage { get; private set; }

        public InvestmentAccount(string owner) : base(owner) {}

        public void EnableLeverage()
        {
            Leverage = true;
        }
        
        public void DisableLeverage()
        {
            Leverage = false;
        }

    }
}
