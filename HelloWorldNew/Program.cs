using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";
            Console.WriteLine(hello);
            Console.ReadLine();
            Console.WriteLine("Beep");
            Console.WriteLine("I SAID " + hello.ToUpper());
            Console.Beep();
            Console.WriteLine("Boop");
            Console.WriteLine("Invariant Upper " + hello.ToUpperInvariant());
            Console.WriteLine("Invariant Lower " + hello.ToLowerInvariant());

            int num1 = 7, num2 = 5, num3 = 1;
            
            // Console.WriteLine("The numbers saved are: " + num1 +" "+ num2 +" "+ num3);
        }
    }
}