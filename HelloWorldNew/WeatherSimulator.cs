namespace HelloWorld;

public class WeatherSimulator
{
    public static void Simulator()
    {
        Console.WriteLine("Please input the amount of days to simulate weather for.");
        int days = int.Parse(Console.ReadLine());
        int[] temperature = new int[days];
        string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];

        Random random = new Random();
        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 40);
            weatherConditions[i] = conditions[random.Next(random.Next(conditions.Length))];
            Console.WriteLine(temperature[i] + " " + weatherConditions[i]);
        }
    }
}