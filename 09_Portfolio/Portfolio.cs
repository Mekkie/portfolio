using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        public List<Asset> Stocks = new List<Asset>();
        public Portfolio(List<Asset> stocks)
        {
            Stocks = stocks;
        }

        public Portfolio()
        {

        }

        public double GetTotalValue()
        {
            double Total = 0;
            foreach (Asset item in Stocks)
            {
                Total += item.GetValue();
            }
            return Total;
        }

        public void AddAsset(Asset OrigAsset)
        {
            Stocks.Add(OrigAsset);
        }
    }
}