using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyanmarPeople mp = new MyanmarPeople();
            mp.Name = "U Mya";
            mp.Address = "Yangon";
            mp.DisplayInfo();
            mp.SayGreetingMessage();

            JapanesePeople jp = new JapanesePeople()
            {
                Name="jukky",
                Address="Toko"
            };
            jp.DisplayInfo();
            jp.SayGreetingMessage();

            EnglishPeople ep = new EnglishPeople()
            {
                Name="Jonh Smith",
                Address="USA"
            };
            ep.DisplayInfo();
            ep.SayGreetingMessage();

            Console.WriteLine("Payroll calculation is here .");
            Staff staff1 = new Staff();
            staff1.Name = "U Aye Mya";
            staff1.Address = "No(12),DawBone Township,Yangon";
            staff1.Email = "ayemya@gmail.com";
            staff1.BaseSalary = 300000;
            staff1.ShowStaffDetailInfo();
            IPayrollService payroll = new PayrollService();
            double monthdalary=payroll.CalculatePayroll(staff1.BaseSalary, 30, 10000, 0);
            payroll.SalaryTransferToBankAccount(102307410, monthdalary);
            ICreditCard creditCard = new BankAccount();
            double resultOfUSDAmt = creditCard.GetUSDExchangeRate(500);
            Console.WriteLine("Current Exchange Rate of USD "+resultOfUSDAmt);//750000
            double resultOfYanAmt = creditCard.GetYanExchangeRate(500);
            Console.WriteLine("Current Exchange Rate Of Yan "+resultOfYanAmt);//500000

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
