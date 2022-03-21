using System;
namespace OOPDemo{
    public class Student{
        private int RollNO;
        private string Name;
        private string Email;
        private string Phone;
        private int Age;
        public void Register(string name){
            Console.WriteLine(name);
        }
        public void SetAge(int age){
            if (age < 0)
                throw new Exception("Invalid age.");
            else 
                Age= age;
        }
        public void SetRollNo(int rollNo){
            if (rollNo <= 0)
                throw new Exception("Invalid rollNo.");
            else
                RollNO = rollNo;
        }
        public void SetName(string name){
            if (name==null || name=="")
                throw new Exception("Invalid Name.");
            else
            Name = name;
        }
        public void SetEmail(string email){
            if (!email.Contains("@"))
                throw new Exception("Invalid Email.");
            else
            Email = email;
        }
        public void SetPhone(string phone){
            if (phone.Length < 11 || phone.Length>11)
                throw new Exception("Invalid phone.");
            else
                Phone = phone;
        }
       public void GetInfo(){
            Console.WriteLine("Student Info");
            Console.WriteLine("RollNo:" + RollNO);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Phone:" + Phone);
        }
    }
}
