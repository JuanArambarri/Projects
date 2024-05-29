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
            Console.WriteLine(temperature[i] + "° & " + weatherConditions[i]);
        }
        Console.WriteLine("The average temperature for the amount of days inputted was {0}",AverageTemperature(temperature));
        
        Console.WriteLine("The highest temperature was {0}, and the lowest was {1}.",temperature.Max(), temperature.Min());
        
        Console.WriteLine("The most common Weather Condition was " +MostCommonWeatherCondition(weatherConditions));
        
    }

    public static string MostCommonWeatherCondition(string[] WeatherCondition)
    {
        int SunnySum = 0;
        int CloudySum = 0;
        int RainySum = 0;
        int SnowySum = 0;
        for (int i = 0; i < WeatherCondition.Length; i++)
        {
            switch (WeatherCondition[i])
            {
                case ("Sunny"):
                    SunnySum++;
                    break;
                case ("Cloudy"):
                    CloudySum++;
                    break;
                case ("Rainy"):
                    RainySum++;
                    break;
                case ("Snowy"):
                    SnowySum++;
                    break;
            }
        }

        if (SunnySum > CloudySum && SunnySum > RainySum && SunnySum > SnowySum)
        {
            return "Sunny";
        }
        if (CloudySum > SunnySum && CloudySum > RainySum && CloudySum > SnowySum)
        {
            return "Cloudy";
        }
        if (RainySum > CloudySum && RainySum > SunnySum && RainySum > SnowySum)
        {
            return "Rainy";
        }
        else
        {
            return "Snowy";
        }
    }

    public static double AverageTemperature(int[] temperature)
    {
        float sum = 0f;
        for (int i = 0; i < temperature.Length; i++)
        {
            sum += temperature[i];
        }

        double average = sum / temperature.Length;

        return average;
    }
}