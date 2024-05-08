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
         string myName;
         Console.Write("Please enter your name and press enter: ");
         myName = Console.ReadLine();
         string inputToUpper = myName.ToUpper();
         string inputToLower = myName.ToLower();
         string inputNoWhitespace = myName.Trim();
         var inputSubString = myName.Substring(0,2);

         Console.WriteLine("Solutions:{0} \n{1} \n{2} \n{3}", inputToUpper, inputToLower, inputNoWhitespace, inputSubString);
         
         //Console.WriteLine("solutions: " + inputToUpper + "\n" + inputToLower + "\n" + inputNoWhitespace + "\n" + inputSubString);
         
           //Console.WriteLine("String concatenation");
           /*
            int age = 31;
            string name = "Alfonso";
           */
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
            
            //string stringForFloat = "0.85";
            //string stringForInt = "12345";
            //Console.WriteLine(Int32.Parse(stringForInt) + " " + float.Parse(stringForFloat));

            //string hello = "Hello World";
            //Console.WriteLine(hello);
            //string userInput = Console.ReadLine();

            //Implicit conversion (from smaller data type to bigger)
            //kint num = 123456708;
            //long bigNum = num;
            //float myFloat = 13.37f;
            //double myNewDouble = myFloat;

            //Casting [Explicit conversion]
            //double myDouble = 13.37;
            //int myInt;

            //type conversion
            //string myString = myDouble.ToString(); //  "13.37"
            //myFloat.ToString();

            //myInt = (int)myDouble;
            //Console.WriteLine(myInt);
            // Will forcibly transform myDouble to int. Prints 13.

            /* {0} is replaced by the variable placed after the comma.
            Can also take more inputs using {n+1}
            view example below */
            /*
            Console.WriteLine("You have entered {0} {1}", userInput,hello);

            string myString1 = "13";

            // if myString is not parseable, it will throw an exemption.
            int _num = Int32.Parse(myString1);

            int num1 = 7, num2 = 5, num3 = 1;
            Console.WriteLine("The numbers saved are: " + num1 +" "+ num2 +" "+ num3 + "\n"+ userInput);
            */
        }
    }
}


//<summary>
//This is a piece of useless code
//</summary>
//XML style commenting