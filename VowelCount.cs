using System;
class VowelCount{
    static void Main(){
        char vowel='A';
        int count=0;
     //1 Decision with 10 conditions (should use switch case )
      switch(vowel){
        case 'a':   Console.WriteLine("this is vowel.");count++;break;
        case 'A':   Console.WriteLine("this is vowel.");count++;break;
        case 'e':   Console.WriteLine("this is vowel.");count++;break;
        case 'E':   Console.WriteLine("this is vowel.");count++;break;
        case 'i':   Console.WriteLine("this is vowel.");count++;break;
      }
      Console.WriteLine("vowel count is");
      Console.WriteLine(count);//1
    }
}