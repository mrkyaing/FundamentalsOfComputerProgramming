using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public static class Utilitity
    {
    public  static  int x = 100;
     public static void TellMeTodayName()
        {
            Console.WriteLine(DateTime.Now.Day);
        }

      public  static void TellMeWhatTimeIsIt()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
