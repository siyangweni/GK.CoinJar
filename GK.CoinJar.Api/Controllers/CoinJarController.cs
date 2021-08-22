using System;
using GK.CoinJar.Contracts;
using GK.CoinJar.Contracts.Models;
using Microsoft.AspNetCore.Mvc;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace GK.CoinJar.Api.Controllers
{
    [ApiController]
    [Route("api/v1/CoinJar")]
    public class CoinJarController : ControllerBase
    {
        private readonly ICoinJarService _coinJarService;

        [HttpPost]
        [Route("AddCoin")]
        public IActionResult AddCoin([FromBody] Coin coin)
        {
            if (coin == null)
            {
                return new BadRequestResult();
            }

            try
            {
                _coinJarService.AddCoin(coin);
            } catch (Exception exc)
            {
                
            }

            return new OkResult();
        }

        [HttpGet]
        [Route("Reset")]
        public IActionResult Reset()
        {
            try
            {
                _coinJarService.Reset();
            }
            catch (Exception exc)
            {
                
            }

            return new OkResult();
        }

        [HttpGet]
        [Route("GetTotal")]
        public decimal GetTotal()
        {
            try
            {
                return _coinJarService.GetTotalAmount();
            }
            catch (Exception exc)
            {
                
            }

            return 0;
        }

        public CoinJarController(ICoinJarService coinJarService)
        {
            _coinJarService = coinJarService;
        }
    }
}