using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.Name = "user1";
            u1.Email = "user1@yahoo.com";
            u1.Password = "123456";
            u1.DisplayUserInfo();

            User u2 = new User()
            {
                Name = "user2",
                Email = "user2@gmail.com",
                Password = "123654856423"
            };

            int[] examMaks = new int[10];//0 to 9
            examMaks[0] = 1;
            List<int> items = new List<int>();
            items.Add(1);
            items.Add(10);
            items.Add(200);
            items.Add(300);
            //items.Add("Hello");//Sematic Error 
            foreach(int me in items)
            {
                Console.WriteLine(me);
            }
            //1
            //10
            //200
            //300
            IList<User> allUsers = new List<User>();
            allUsers.Add(u1);
            allUsers.Add(u2);
            foreach(User u in allUsers)
            {
                u.DisplayUserInfo();
            }
            ArrayList allItems = new ArrayList();
            allItems.Add("Hi");
            allItems.Add(100);
            allItems.Add(100.23);
            allItems.Add(100);
            allItems.Add("today is saturday");
            for(int i = 0; i < allItems.Count; i++)
            {
                Console.WriteLine(allItems[i]);
            }

            try
            {
                Stack<int> data = new Stack<int>();
                data.Push(1);
                data.Push(2);
                data.Push(3);
                int sizeofStack = data.Count;
                for (int i = 0; i < sizeofStack; i++)//3
                {                 
                    Console.WriteLine(data.Peek());
                    data.Pop();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//stack is empty
            }

            try
            {
                Queue<string> sayGreeting = new Queue<string>();
                sayGreeting.Enqueue("hi");//0
                sayGreeting.Enqueue("hello");//1
                sayGreeting.Enqueue("good evening");//2
                int queueCount = sayGreeting.Count;//3
                for(int i = 0; i <queueCount; i++)//sayGreeging wil be 3
                {
                    Console.WriteLine(sayGreeting.Dequeue());//
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Queue is empty
            }

            int pass = 0;
            int failure = 0;
            int studentCount = 1;
            while (studentCount <= 10)
            {
                Console.Write("Enter Mark");
                int mark =int.Parse( Console.ReadLine());
                if (mark >= 40)
                {
                    pass++;
                }
                else
                {
                    failure++;
                }
                studentCount++;
            }
            Console.WriteLine("passed Student Count " + pass);
            Console.WriteLine("failed student count " + failure);
            if (pass >= 8)
            {
                Console.WriteLine("raise tution");
            }

            try
            {
                int[] numbers = { 11, 12, 34, 56, 77, 120, 9 };
                Console.Write("Enter Searh Key");
                int searchKey = int.Parse(Console.ReadLine());//8
                LinearSearch linearSearch = new LinearSearch();//Create the object (instance of LinearSearch Class)
                int reuslt = linearSearch.SearchKey(searchKey, numbers);
                if (reuslt == (-1))
                {
                    Console.WriteLine("your finding key don't found in array");
                }
                else
                {
                    Console.WriteLine("your finding key found in array ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("we only accept number value in your input");
            }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
