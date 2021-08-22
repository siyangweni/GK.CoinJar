namespace GK.CoinJar.Contracts
{
    public interface ICoinCollection
    {
        void AddCoin(ICoin coin);
        void Reset();
        decimal GetTotalAmout();
    }
}
