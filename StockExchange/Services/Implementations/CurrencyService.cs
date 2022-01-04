using StockExchange.Services.Interfaces;
using StockExchangeLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockExchange.Services.Implementations
{
    public class CurrencyService : ICurrencyService
    {
        protected HttpClient client { get; set; }
        private string uri = "";
        private string currency = "Currencies";

        public CurrencyService(string uri)
        {
            this.uri = uri;
        }
        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var response = await client.GetAsync(currency);


            if (response.IsSuccessStatusCode)
            {
                // Ya no hace falta, estoy convirtiendo el json directamente a mis clases
                //string chorizoJson = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadAsAsync<List<Currency>>();
            }

            return null;
        }

        public async Task<Currency> GetCurrencyByIdAsync(int id)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var response = await client.GetAsync(currency + "/" + id);


            if (response.IsSuccessStatusCode)
            {
                // Ya no hace falta, estoy convirtiendo el json directamente a mis clases
                //string chorizoJson = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadAsAsync<Currency>();
            }

            return null;
        }
    }
}
