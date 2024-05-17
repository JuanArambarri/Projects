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
   QuizzApp();
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

   //switches
   PrintDay();

   static void PrintDay()
   {
    int day = 3;
    switch (day)
    {
     case 1:
      Console.WriteLine("Monday");
      break;
     case 2:
      Console.WriteLine("Tuesday");
      break;
     case 3:
      Console.WriteLine("Wednesday");
      break;
     case 4:
      Console.WriteLine("Thursday");
      break;
     case 5:
      Console.WriteLine("Friday");
      break;
     case 6:
      Console.WriteLine("Saturday");
      break;
     case 7:
      Console.WriteLine("Sunday");
      break;
     default:
      Console.WriteLine("Another Day");
      break;
    }
   }


   //nesting ifs
   bool isAdmin = false;
   bool isRegistered = true;
   Console.WriteLine("Please input user name.");
   string userName = Console.ReadLine();

   isAdmin = userName.Equals("Admin") ? true : false;
   Console.WriteLine(isAdmin);

   if (isRegistered && userName != "")
   {
    Console.WriteLine(isAdmin ? "You're an Admin" : "Hi there, registered user, you have logged in as " + userName);
   }
   else
   {
    Console.WriteLine("please input a user name");
   }

   Console.WriteLine("What is the temperature like?");
   string temperature = Console.ReadLine();
   int number;
   if (int.TryParse(temperature, out number))
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
   //QuizzMethod

   static void QuizzApp()
   {
    //Questions & Answers
    int score = 0;
    string question1 = "What is the capital of Germany";
    string answer1 = "Berlin";
    Console.WriteLine(question1);
    if (Console.ReadLine().Equals(answer1))
    {
     score++;
     Console.WriteLine();
    }else Console.WriteLine("The correct answer is: " +answer1 + "\n");

    string question2 = "What is 2+2";
    string answer2 = "4";
    Console.WriteLine(question2);
    if (Console.ReadLine().Equals(answer2))
    {
     score++;
     Console.WriteLine();
    }else Console.WriteLine("The correct answer is: " +answer2 + "\n");

    string question3 = "What color do you get by mixing blue and yellow"; 
    string answer3 = "Green";
    Console.WriteLine(question3);
    if (Console.ReadLine().Equals(answer3))
    {
     score++;
     Console.WriteLine();
    }else Console.WriteLine("The correct answer is: " +answer3 + "\n");
    
    switch (score)
    {
     case 1:
      Console.WriteLine("You only had one right answer, please try again! \n ");
      break;
     case 2:
      Console.WriteLine("You had two right answers, you were almost there! \n");
      break;
     case 3:
      Console.WriteLine("Congratulations! You got all of them right! \n ");
      break;
    }
   }
  }
 }
}