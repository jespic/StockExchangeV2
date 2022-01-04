using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace StockExchange.Controllers
{
    public class CurrenciesController : BaseController
    {
        public CurrenciesController(IConfiguration configuration) : base(configuration)
        {
        }

        // GET: Countries
        public async Task<IActionResult> Index()
        {
            return base.View(
                await currencyService.GetCurrenciesAsync()
                );
        }
    }
}
