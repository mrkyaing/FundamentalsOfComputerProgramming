using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
  public  interface IPayrollService
    {
        double CalculatePayroll(int salary, int workingDays, int benefit, int deduction);
        void SalaryTransferToBankAccount(int accountNo, double totalSalary);
    }
}
