using System;

namespace ch03_Project_3_1_Temperature_Converter 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Temperature Converter!\n");

            string choice = "y";
            while (choice.Equals("y"))
            {
                double degreesInFahrenheit = MyConsole.getDouble("Enter " +
                    "degrees in Fahrenheit: ");
                double degreesInCelcius = ((degreesInFahrenheit - 32) * 5 / 9);
                double formattedDegreesInCelcius = Math.Round(degreesInCelcius, 2);

                Console.WriteLine("Degrees in Celcius: " + formattedDegreesInCelcius + "\n");
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
