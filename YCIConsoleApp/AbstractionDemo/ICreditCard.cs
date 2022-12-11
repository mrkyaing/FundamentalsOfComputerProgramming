using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
  public  interface ICreditCard
    {
        double GetSGExchangeRate(double amount);//only method signature (no-body metohd)
        double GetUSDExchangeRate(double amount);
        double GetYanExchangeRate(double amount);
    }
}
