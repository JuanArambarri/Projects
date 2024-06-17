using System;
using System.Text;
using System.Threading.Channels;

namespace HelloWorld
    
//In C#, the static keyword is used to declare members of a class that
//belong to the class itself, rather than to any specific instance of the class.
{
 class Program
 {
  // www.dofactory.com/reference/csharp-coding-standards
  //variables created before Main will be a "Field", meaning it is usable in the whole program.
  static void Main(string[] args)
  {
         //Object-Oriented Programing with "Car" class examples.
         Car audi = new Car("A8", "Audi", true);
         Car genericCar = new Car("306", "Peugot", false);

         Console.WriteLine("Number of cars produced: " +Car.NumberOfCars);//accessing the public static variable NumOfCars
         
         Customer bot = new Customer();
         Customer jorge = new Customer("Jorge");
         bot.SetDetails("Bot", "Circuit line 55","01001001010110010");

         jorge.customerDetails(); //not exposing Customer variables
         
         /*
         Console.WriteLine("Please enter the Brand name.");
         // "setting brand"
         audi.Brand = Console.ReadLine();
         // "getting brand"
         Console.WriteLine("Brand is " +audi.Brand);
         */

         List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 99, 234, 6, 13, 20, 11, 2, 1 };
         
         /*
          * Lambda works under this assumption "Take an input x and turn it into ..."
          * x => x * x; (Take input x and multiply x by x
          * Short way of creating a method that will be used in a specific place and in no other place.
          * Left side of "=>" is the parameter.
          * Right side of "=>" is the expresssion or action to perform.
          */
         
         // A delegate is like a pointer or a reference to a method. Allows to pass methods as arguments, store in
         // variables and be called later. (A predicate is a delegate)
         Predicate<int> isGreaterThanTen = GreaterThanTen; // can have a method after the = sign, must not have ().

         bool GreaterThanTen(int x)
         {
             return x > 10;
         }

         bool hasLargeNumber = numbers.Any(x => x > 500);
         Console.WriteLine("Is there a number greater than 500? " + hasLargeNumber);
         List<int> moreThanTen = numbers.FindAll(isGreaterThanTen); //Will return a List<int>
         numbers.Sort();
         Console.WriteLine("Sorted List");
         foreach (var number  in numbers)
         {
             Console.WriteLine(number);
         }

         Console.WriteLine("---------------------------------------------------------------------------------------");
         foreach (var number  in moreThanTen)
         {
             Console.WriteLine(number);
         }
         TicTacToeTheGame.TicTacToe();
         WeatherSimulator.Simulator();

         /*
         Challenges.MyArrayTraining();
         AdventureGame.Play();
         Challenges.RandomNumberGuesser();
         QuizzApp.Quizz();
         Challenges.GreetFriend();
         */
 
  }
 }
}