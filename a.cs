using System;
using System.Collections.Generic;
using System.Linq;
class a {
    public static void Main () {
        List<int> dataSource1 = new List<int> () { 1, 2, };
        List<int> dataSource2 = new List<int> () { 1, 2, 3, 5, 8, 9, 10 };
        //Method Syntax
        var MS = dataSource2.Except (dataSource1).ToList ();
        foreach (var item in MS) {
            Console.WriteLine (item);
        }
    }
}