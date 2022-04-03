using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
  public  interface ICreditCard
    {
        double GetSGExchangeRate(double amount);
        double GetUSDExchangeRate(double amount);
        double GetYanExchangeRate(double amount);
    }
}
