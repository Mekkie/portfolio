using System;
using System.Globalization;

namespace _09_Portfolio
{
    internal class Stock : Asset
    {
        public double NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        public double GetValue()
        {
            return (NumShares * PricePerShare);
        }
        public Stock(string symbol = "", double pricepershare = 0, double numshares = 0)
        {
            this.NumShares = numshares;
            this.PricePerShare = pricepershare;
            this.Symbol = symbol;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double Value = 0;
            foreach (Stock Aktie in stocks)
            {
                Value += Aktie.GetValue();
            }
            return Value;
        }
        public override string ToString()
        {
            return String.Format("Stock[symbol={0},pricePerShare={1},numShares={2}]", Symbol, PricePerShare.ToString(CultureInfo.InvariantCulture), NumShares);
        }
        public bool Equals(Stock Aktie)
        {
            if (Aktie.NumShares == this.NumShares && Aktie.Symbol == this.Symbol && Aktie.PricePerShare == this.PricePerShare) return true;
            else return false;
        }

        internal static object TotalValue(Asset[] portfolio)
        {
            double totalValue = 0;

            for (int i = 0; i < portfolio.Length; i++)
            {
                totalValue += portfolio[i].GetValue();
        }

            return totalValue;
        }
        
            
    }
}