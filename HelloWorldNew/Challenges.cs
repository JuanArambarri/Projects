namespace HelloWorld;


public class Challenges
{
    public static void StringMethods()
    {
        string genericString;
        string toSearch;
        int index;
        Console.WriteLine("Enter a string here: ");
        genericString = Console.ReadLine();
        Console.WriteLine("Enter the character to search: ");
        toSearch = Console.ReadLine();

        index = genericString.IndexOf(toSearch);

        Console.WriteLine("The index of said character is: " + index);

        string firstName;
        string lastName;
        string fullName;
         
        Console.WriteLine("Enter your first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        lastName = Console.ReadLine();
        fullName = (firstName + " " + lastName);
        Console.WriteLine(fullName);
        Console.Read();
    }

    public static void StringConcatenation()
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

    }
    
}