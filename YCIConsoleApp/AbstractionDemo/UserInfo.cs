using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class UserInfo :PayrollService, IShowDetail
    {
        public void ShowStaffDetailInfo()
        {
            Console.WriteLine("Hi,i can do multi-inheritance with interface.");
        }
    }
}
