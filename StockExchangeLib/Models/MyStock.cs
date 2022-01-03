using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeLib.Models
{
    public class MyStock
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public double BuyPrice { get; set; }

        public DateTime BuyDate { get; set; }

        public int StockId { get; set; }

        public Stock Stock { get; set; }

        public int BagUserId { get; set; }

        public User User { get; set; }
    }
}
