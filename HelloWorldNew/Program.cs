using System;

namespace HelloWorld
{
    class Program
    {
        // www.dofactory.com/reference/csharp-coding-standards
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            Console.WriteLine(Int32.Parse(stringForInt) + " " + float.Parse(stringForFloat));
            
            string hello = "Hello World";
            Console.WriteLine(hello);
            string userInput = Console.ReadLine();
            
            //Implicit conversion (from smaller data type to bigger)
            int num = 123456708;
            long bigNum = num;
            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            
            //Casting [Explicit conversion]
            double myDouble = 13.37;
            int myInt;
            
            //type conversion
            string myString = myDouble.ToString(); //  "13.37"
            myFloat.ToString();

            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            // Will forcibly transform myDouble to int. Prints 13.
            
            
                /* {0} is replaced by the variable placed after the comma. 
                Can also take more inputs using {n+1}
                view example below */
            Console.WriteLine("You have entered {0} {1}", userInput,hello);

            string myString1 = "13";

            // if myString is not parseable, it will throw an exemption.
            int _num = Int32.Parse(myString1);
            
            int num1 = 7, num2 = 5, num3 = 1;
            Console.WriteLine("The numbers saved are: " + num1 +" "+ num2 +" "+ num3 + "\n"+ userInput);
        }
    }
}


//<summary>
//This is a piece of useless code
//</summary>
//XML style commenting