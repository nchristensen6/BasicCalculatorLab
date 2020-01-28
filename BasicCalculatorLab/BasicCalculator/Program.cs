using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the Temperature in Farenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int ActualTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int RelativeHumidity = int.Parse(Console.ReadLine());

            int dewpoint = ActualTemp - 9 * (100 - RelativeHumidity) / 25;
            Console.WriteLine("The Dewpoint is " + dewpoint);

            Console.WriteLine("Ënter Windspeed");
            int Windspeed = int.Parse(Console.ReadLine());

            double WindChill = 35.74 + 0.6215 * ActualTemp - 35.75 * Math.Pow(Windspeed, .16) + 0.4275 * ActualTemp * Math.Pow(Windspeed, .16);


            Console.WriteLine("The answer is " + WindChill);
        }
    }
}
