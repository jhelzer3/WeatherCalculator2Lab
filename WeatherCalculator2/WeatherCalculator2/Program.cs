using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");


            string input = "";
            

            
            Console.WriteLine("Please enter the temperature");

            input = Console.ReadLine();

            int temperature = int.Parse(input);

            // Get the windspeed from the user
            Console.WriteLine("Please nter the wind speed");

            input = Console.ReadLine();

            int windSpeed = int.Parse(input);

            // Calculate the wind chill

            double windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);
        }
    }
}
