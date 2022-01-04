using StockExchangeLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockExchange.Services.Interfaces
{
    public interface ICurrencyService
    {
        public Task<List<Currency>> GetCurrenciesAsync();
        public Task<Currency> GetCurrencyByIdAsync(int id);
    }
}
