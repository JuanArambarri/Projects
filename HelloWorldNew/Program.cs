using System;
using System.Text;
using System.Threading.Channels;

namespace HelloWorld

{
 class Program
 {
  // www.dofactory.com/reference/csharp-coding-standards
  //variables created before Main will be a "Field", meaning it is usable in the whole program.
  static void Main(string[] args)
  {
         //Object-Oriented Programing with "Car" class examples.
         Car audi = new Car("A8", "Audi", true);

         Customer juan = new Customer("Juan");
         Customer martin = new Customer("Martin", "Madison 300");
         Customer bot = new Customer();

         bot.SetDetails("Bot", "Circuit line 55","01001001010110010"); 
         
         Console.WriteLine($"Customer name: {bot.Name}, address: {bot.Address}. Contact number: {bot.ContactNumber}");
         Console.WriteLine($"Customer name: {martin.Name}, address: {martin.Address}. Contact number: {martin.ContactNumber}");

         Console.WriteLine(juan.Name);

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