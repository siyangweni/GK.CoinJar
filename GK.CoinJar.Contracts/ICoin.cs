namespace GK.CoinJar.Contracts
{
    public interface ICoin
    {
        decimal Amount { get; }
        decimal Volume { get; }
    }
}