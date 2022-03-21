using System;
class StudentRollCall {
    static void Main () {
        Start : try {
            Console.Write ("Enter number of students :");
            int numval = Convert.ToInt32 (Console.ReadLine ());
            string[] students = new string[numval];
            for (int i = 0; i < students.Length; i++) {
                Console.Write ("Enter student" + " " + (i + 1) + " " + "Name :");
                string name = Console.ReadLine ();
                if (IsNameContainNum (name)) {
                    Console.WriteLine ("we only accept name in text format");
                    goto Start;
                } else {
                    students[i] = name;
                }
            }
            Console.WriteLine ("All students..");
            Console.WriteLine ();
            Console.WriteLine ("No Name");
            Console.WriteLine ("== ======");
            for (int j = 0; j < students.Length; j++) {
                Console.WriteLine ((j + 1) + "  " + students[j]);
            }
        }
        catch (Exception b) {
            Console.WriteLine ("Error occur because " + b.Message);
            Console.Write ("Fill again: ");
            goto Start;
        }
    }
    static bool IsNameContainNum (string name) {
        bool status = false;
        for (int i = 0; i < name.Length; i++) {
            if (char.IsDigit (name[i])) { //Checking each char is Digit(number) 
                status = true;
                break;
            }
        }
        return status;
    }
}