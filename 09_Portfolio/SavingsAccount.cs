using System;
using _09_Portfolio;

namespace _09_Portfolio
{
    internal class SavingsAccount : Asset
    {
        
        private double Interest;
        private string AccountName;
        private double Value;


        public SavingsAccount(string accountname, double value, double interest)
        {
            AccountName = accountname;
            Value = value;
            Interest = interest;
        }

        public double InterestRate
        {
            get
            {
                return Interest;
            }
            internal set
            {
                Interest = value;
            }
        }

        public override string ToString()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            return "SavingsAccount[value=" + GetValue().ToString(".0") + ",interestRate=" + Interest + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value += Interest * Value / 100;
        }

    }
}