using GK.CoinJar.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GK.CoinJar.Data
{
    public class CoinCollection : ICoinCollection
    {
        private static IList<ICoin> _coins;
        private Object coinLock = new Object();
        public void AddCoin(ICoin coin)
        {
            lock (coinLock)
            {
                _coins.Add(coin);
            }
        }

        public decimal GetTotalAmout()
        {
            return _coins.Sum(x => x.Amount);
        }

        public void Reset()
        {
            _coins = new List<ICoin>();
        }

        public CoinCollection()
        {
            _coins = new List<ICoin>();
        }
    }
}
