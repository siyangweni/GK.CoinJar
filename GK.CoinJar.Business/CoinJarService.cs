using GK.CoinJar.Contracts;

namespace GK.CoinJar.Business
{
    public class CoinJarService : ICoinJarService
    {
        private readonly ICoinCollection _coinCollection;

        public decimal GetTotalAmount()
        {
            return _coinCollection.GetTotalAmout();
        }
        
        public void AddCoin(ICoin coin)
        {
            if (coin == null || coin.Volume != 42)
                return;
            
            _coinCollection.AddCoin(coin);
        }

        public void Reset()
        {
            _coinCollection.Reset();
        }

        public CoinJarService(ICoinCollection coinCollection)
        {
            _coinCollection = coinCollection;
        }
    }
}