using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeLib.Models
{
    public class Country
    {
        public Country(string name)
        {
            Name = name;

            Currencies = new HashSet<Currency>();
        }

        public int Id { get; set; }

        public string Name { get; set; }


        public string ApiName { get; set; }

        //public CurrencyType CurrencyType { get; set; }

        public ICollection<Currency> Currencies { get; set; }

        public ICollection<Market> Markets { get; set; }
    }
}
