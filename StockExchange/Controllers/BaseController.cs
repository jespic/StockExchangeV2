using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StockExchange.Services.Implementations;

namespace StockExchange.Controllers
{
    public class BaseController : Controller
    {
        protected CountryService service;
        public BaseController(IConfiguration configuration)
        {
            service = new CountryService(configuration.GetConnectionString("JsonBD"));
        }
    }
}
