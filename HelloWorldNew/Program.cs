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
         
         
         /*
          * Concatenation
          * Console.WriteLine("Hello my name is " +name+ " , I am " +age+ " years old.");
          */
         /*
          * Formatting
          * Console.WriteLine("Hello my name is {0}, I am {1} years old",name,age);
          */
         /*
          * Interpolation
          * Console.WriteLine($"My name is {name}. I am {age}　years old.");
          */
         /*
          * Verbatim Strings
          * ignores formatting (for example \u or \n)
          * Console.WriteLine(@"Muahaha \n you have no powers here!.");
          */
         /*
          * escape character \.
          * string s1 = "this is \"something\"";
          * Console.WriteLine(s1);
          */
         /*
          * Casting [Explicit conversion]
          * double myDouble = 13.37;
          * int myInt;
          */
         
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