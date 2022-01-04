using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StockExchange.Services.Implementations;

namespace StockExchange.Controllers
{
    public class BaseController : Controller
    {
        protected CountryService countryService;
        protected CurrencyService currencyService;
        public BaseController(IConfiguration configuration)
        {
            countryService = new CountryService(configuration.GetConnectionString("JsonBD"));
            currencyService = new CurrencyService(configuration.GetConnectionString("JsonBD"));
        }
    }
}
