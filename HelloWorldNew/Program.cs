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

         Customer juan = new Customer("Juan");
         Customer martin = new Customer("Martin", "Madison 300");
         Customer bot = new Customer();
         Customer jorge = new Customer("Jorge");
         bot.SetDetails("Bot", "Circuit line 55","01001001010110010");

         jorge.customerDetails(); //not exposing Customer variables

         Console.WriteLine("Please enter the Brand name.");
         // "setting brand"
         audi.Brand = Console.ReadLine();
         // "getting brand"
         Console.WriteLine("Brand is " +audi.Brand);
         
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