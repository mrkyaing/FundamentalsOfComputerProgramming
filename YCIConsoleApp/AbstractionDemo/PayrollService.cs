using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class PayrollService : IPayrollService
    {
        public double CalculatePayroll(int salary, int workingDays, int benefit, int deduction)
        {
            double result = (salary / 30) * workingDays + benefit - deduction;
            return result;
        }

        public void SalaryTransferToBankAccount(int accountNo, double totalSalary)
        {
            Console.WriteLine("Payroll have been run successfully.You can withdraw your salary in your bank account");
            Console.WriteLine(totalSalary + " is transfer to this bank account " + accountNo);
        }
    }
}
