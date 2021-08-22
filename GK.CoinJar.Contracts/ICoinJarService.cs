namespace GK.CoinJar.Contracts
{
    public interface ICoinJarService
    { 
        void AddCoin(ICoin coin);
        decimal GetTotalAmount();
        void Reset();
    }
}