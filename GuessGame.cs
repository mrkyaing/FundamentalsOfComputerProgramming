using System;
class GuessGame{
    static void Main(){
        Random rdm=new Random();//create Random Object 
        int hiddenvalue=rdm.Next(20);//will get ramdon value between 0 .....20
        //Console.WriteLine(hiddenvalue);
        Console.WriteLine("Guess game (0-20) started.");
        Console.Write("Guess my Number:");
        int inputvalue=Convert.ToInt32(Console.ReadLine()); 
        bool IsNextTime=true;
        int count=0;
        while(IsNextTime){
            count++;
            if(hiddenvalue==inputvalue){
                Console.WriteLine("Wow...you got it right");
                Console.WriteLine("Game end");
                IsNextTime=false;
                Console.WriteLine("you found at "+count);
            }
            else {
                Console.WriteLine("No...you got it wrong");
                 Console.Write("Guess again:");
                inputvalue=Convert.ToInt32(Console.ReadLine());
            }
        }//end of while  
    }//end of main
}//end of class 