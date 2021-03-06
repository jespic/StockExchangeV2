using StockExchange.Services.Interfaces;
using StockExchangeLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockExchange.Services.Implementations
{
    public class CountryService : ICountryService
    {
        protected HttpClient client { get; set; }
        private string uri = "";
        private string country = "Countries";

        public CountryService(string uri)
        {
            this.uri = uri;
        }
        public async Task<List<Country>> GetCountriesAsync()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var response = await client.GetAsync(country);


            if (response.IsSuccessStatusCode)
            {
                // Ya no hace falta, estoy convirtiendo el json directamente a mis clases
                //string chorizoJson = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadAsAsync<List<Country>>();
            }

            return null;
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            var response = await client.GetAsync(country + "/" + id);


            if (response.IsSuccessStatusCode)
            {
                // Ya no hace falta, estoy convirtiendo el json directamente a mis clases
                //string chorizoJson = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadAsAsync<Country>();
            }

            return null;
        }
    }
}
