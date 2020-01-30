using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Calculator Jr. (aka. 'Wouldn'tYouLikeToKnow.WeatherBoy')");


         
            

            
            Console.WriteLine("Please enter the temperature");

            int temperature = int.Parse(Console.ReadLine());
            if (temperature > 50) {
                Console.WriteLine("Please enter relative humidity");
                double relativeHumidity = double.Parse(Console.ReadLine());
                double heatIndex = .5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * .094));
                Console.WriteLine("The heat index is" + heatIndex + ". YOWZA!!");
            }
            else
            {
                Console.WriteLine("Please enter the wind speed");
                int windSpeed = int.Parse(Console.ReadLine());
                double windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);
                Console.WriteLine("The wind chill is" + windChill + ". Brrrrrrr");
            }





          
        }
    }
}
