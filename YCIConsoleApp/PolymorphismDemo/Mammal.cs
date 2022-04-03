using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
 public   class Mammal
    {
        //proterty full syntax
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color { get; set; }//proterty short syntax
        public int LifeSpan { get; set; }
        public string EatFoodType { get; set; }

    }
}
