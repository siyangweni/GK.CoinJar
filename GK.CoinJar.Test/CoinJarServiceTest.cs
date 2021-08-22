using FluentAssertions;
using GK.CoinJar.Business;
using GK.CoinJar.Contracts;
using GK.CoinJar.Contracts.Models;
using GK.CoinJar.Data;
using NUnit.Framework;

namespace GK.CoinJar.Test
{
    [TestFixture]
    public class CoinJarServiceTest
    {      
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TotalShouldBeResetTest()
        {
            //Arrange
            //var coinCollection = new CoinCollection();
            //var coinJarService = new CoinJarService(coinCollection);

            ////Act
            //coinJarService.Reset();

            ////Assert
            //coinJarService.TotalAmount.Should().Be(0);
        }

        [Test]
        public void AmountAddedToTotalForValidVolumeTest()
        {
            //Arrange
            var coinCollection = new CoinCollection();
            var coinJarService = new CoinJarService(coinCollection);

            //Act
            var oldTotal = coinJarService.GetTotalAmount();
            var coin = new Coin { Amount = 50, Volume = 42 };
            coinJarService.AddCoin(coin);
            var newTotal = oldTotal + 50;

            //Assert
            coinJarService.GetTotalAmount().Should().Be(newTotal);
        }

        [Test]
        public void AmountNotAddedToTotalForInvalidVolumeTest()
        {
            //Arrange
            var coinCollection = new CoinCollection();
            var coinJarService = new CoinJarService(coinCollection);

            //Act
            var oldTotal = coinJarService.GetTotalAmount();
            var coin = new Coin { Amount = 50, Volume = 41 };
            coinJarService.AddCoin(coin);
          
            //Assert
            coinJarService.GetTotalAmount().Should().Be(oldTotal);
        }
    }
}
