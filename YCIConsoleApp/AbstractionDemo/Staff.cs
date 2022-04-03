using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
   public class Staff:IShowDetail//Is-A relationship (OOD)
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int BaseSalary { get; set; }
        public Address address { get; set; }//has-A relationship(OOD)

        public void ShowStaffDetailInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Emial:" + Email);
            Console.WriteLine("Address:" + address.Township);
            Console.WriteLine("BaseSalary:" + BaseSalary);
        }
    }
}
