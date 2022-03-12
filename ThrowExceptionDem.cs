using System;
class ThrowExceptionDem {
    static void Main () {
        try {
            int age = 0;
            string nrc = "";
            Console.Write ("Enter Your Name:");
            string username = Console.ReadLine (); //17
            if (IsContainNameInNumber (username)) {
                Console.WriteLine ("try again.");
                return;
            } else {
                Console.Write("Please Enter age:");
                age = int.Parse (Console.ReadLine ()); //Hllo
                Console.Write ("Please Your NRC Type:");
                nrc = Console.ReadLine ();
            }
            bool result = IsAgeGratherThan18 (age, nrc);
            if (result) {
                Console.WriteLine ("you can vote.");
            } else {
                Console.WriteLine ("you can not vote.");
            }
        } //end of try
        catch (Exception e) {
            Console.Write ("Error Occur because of " + e.Message);
        } //end of catch
    }
    static bool IsAgeGratherThan18 (int age, string nrcType) {
        bool result = false;
        if (age <= 0) {
            throw new Exception ("sorry,your age is less than or equal zero.we can't accept it.");
        } else if (nrcType != "N" && nrcType != "n") {
            throw new Exception ("sorry,you are not nation of Country");
        } else if (age >= 18) {
            result = true;
        }
        return result;
    }
    static bool IsContainNameInNumber (string name) { //77
        bool result = false;
        int inputValue = int.Parse (name);
        if (inputValue >= 0 || inputValue <= 0) {
            throw new Exception ("we accept name in text value.");
            result = true;
        }
        return result;
    }
}