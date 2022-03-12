using System;
using StudentInfo;
using TeacherInfo;
namespace SchoolMgt {
    class SchoolMgtSystemMain {
        static void Main () {
            Console.WriteLine ("welcome to School Management System .");
            Teacher myteacher = new Teacher (); //Create Teacher Object it's name myteacher.
            myteacher.name = "Teacher su";
            myteacher.address = "yangon";
            myteacher.role = "senior";
            myteacher.teachingSubject = "English";
            myteacher.Teach (); //calling method by the object with . operator 
            myteacher.SayTeacherPersonalInfo ();
            Console.WriteLine ("==========================================");
            Teacher teacher1 = new Teacher (); //Create Teacher Object it's name myteacher.
            teacher1.name = "Teacher Aye Aye";
            teacher1.address = "MDY";
            teacher1.role = "Junior";
            teacher1.teachingSubject = "Myanmer";
            teacher1.Teach (); //calling method by the object with . operator 
            teacher1.SayTeacherPersonalInfo ();
            Console.WriteLine ("==========================================");
            Student s1 = new Student (); //create student Object .
            s1.name = "Mg Mg ";
            s1.address = "yangon";
            s1.attendingAt = "YCI";
            s1.subject = "C# Programming";
            s1.parentname = "U Mya";
            s1.SayGreetring ();
            Console.WriteLine ("==========================================");
            Student s2 = new Student (); //create student Object .
            s2.name = "Aung Aung";
            s2.address = "Meiktila";
            s2.attendingAt = "YCI";
            s2.subject = "C# Programming";
            s2.parentname = "U Kaung Myat";
            s2.SayGreetring();
            //Random rnd=new Random(); Crate Random Object 
        } //end of Main Method.
    } //end of SchoolMgtSystemMain Class 
} //end of namespace(SchoolMgt)

namespace TeacherInfo {
    public class Teacher {
        //have 
        public string name, address, role, teachingSubject;
        //do 
        public void Teach () {
            Console.WriteLine (name + " is teaching " + teachingSubject);
        }
        public void SayTeacherPersonalInfo () {
            Console.WriteLine ("Name:" + name);
            Console.WriteLine ("Address:" + address);
            Console.WriteLine ("Role:" + role);
            Console.WriteLine ("Subject :" + teachingSubject);
        }
    }
}
namespace StudentInfo {
    public class Student {
        //have 
        public string name, address, parentname, attendingAt, subject;
        //do 
        public void SayGreetring () {
            Console.WriteLine ("Hi,My name is " + name);
            Console.WriteLine ("i am attending at " + attendingAt + " and teaching " + subject);
        }
    }
}