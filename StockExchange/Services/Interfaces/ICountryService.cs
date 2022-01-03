using StockExchangeLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Services.Interfaces
{
    public interface ICountryService
    {
        public Task<List<Country>> GetCountriesAsync();
        public Task<Country> GetCountryByIdAsync(int id);
    }
}
