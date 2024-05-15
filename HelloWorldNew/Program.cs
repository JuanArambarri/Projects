using System;
using System.Text;
using System.Threading.Channels;

namespace HelloWorld

{
    class Program
    {
        // www.dofactory.com/reference/csharp-coding-standards
        
        static void Main(string[] args)
        {
         string friend1 = "Pedro";
         string friend2 = "Luciano";
         string friend3 = "German";
         
         GreetFriend(friend1);
         GreetFriend(friend2);
         GreetFriend(friend3);
         Console.WriteLine("Please input a string");
         string inputText = Console.ReadLine();
         Console.WriteLine(LowUpper(inputText));
         Count(inputText);
         
         //nesting ifs
         bool isAdmin = false;
         bool isRegistered = true;
         Console.WriteLine("Please input user name.");
         string userName = Console.ReadLine();
         
         isAdmin = userName.Equals("Admin") ? true : false;
         Console.WriteLine(isAdmin);
         
         if (isRegistered && userName != "")
         { 
          Console.WriteLine(isAdmin ? "You're an Admin" :"Hi there, registered user, you have logged in as " +userName );
         }
         else
         {
          Console.WriteLine("please input a user name");
         }
         
         Console.WriteLine("What is the temperature like?");
         string temperature = Console.ReadLine();
         int number;
         if (int.TryParse(temperature,out number))
         {
          Console.WriteLine("the Temperature is {0} degrees celcius", number);
         }
         else
         {
          number = 0;
          Console.WriteLine("Input was incorrect. Temperature has been set to {0} degrees celcius.", number);
         }
         
         int input = 25;
         Console.WriteLine(Check(input)
          ? "The number you have entered is even."
          : "The number you have entered is odd.");

        }

        static void GreetFriend(string friendName)
        {
         Console.WriteLine("My bestest friend is: " + friendName);
        }

        static string LowUpper(string inputWord)
        {
         string newWord = inputWord.ToLower() + inputWord.ToUpper();
         return newWord;
         // return inputWord.ToLower() + inputWord.ToUpper();
        }

        static bool Check(int num)
        {
         if (num % 2 == 0)
         {
          return true;
         }
         else
         {
          return false;
         }
        }

        static void Count(string inputWord)
        {
         Console.WriteLine("The amount of characters in your string is {0}", inputWord.Length);
        }
    }
}


//<summary>
//This is a piece of useless code
//</summary>
//XML style commenting