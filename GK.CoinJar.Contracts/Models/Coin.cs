namespace GK.CoinJar.Contracts.Models
{
    public class Coin : ICoin
    {
        public decimal Amount { get; set; }

        public decimal Volume { get; set; }
    }
}