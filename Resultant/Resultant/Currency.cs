using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resultant
{
    //Класс Цена
    public class Price
    {
        public string currency { get; set; }
        public double amount { get; set; }
    }

    //Класс Валюта
    public class Stock
    {
        public string name { get; set; }
        public Price price { get; set; }
        public double percent_change { get; set; }
        public int volume { get; set; }
        public string symbol { get; set; }
    }

    public class StockForVision
    {
        public string name { get; set; }
        public int volume { get; set; }

        public double amount { get; set; }
    }

    public class Stocks
    {
        public List<Stock> stock { get; set; }
        public DateTime as_of { get; set; }
    }
}
