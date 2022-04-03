using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class BankAccount : ICreditCard
    {
        public double GetSGExchangeRate(double amount)
        {
            double result = amount * 1300;
            return result;
        }
        public double GetUSDExchangeRate(double amount)
        {
            double result = amount * 1500;
            return result;
        }
        public double GetYanExchangeRate(double amount)
        {
            double result = amount * 1000;
            return result;
        }
    }
}
