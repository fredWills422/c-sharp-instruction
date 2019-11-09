using System;

namespace ch02_2_3_Rectangular_Calculator 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            String choice = "y";
            while (choice.Equals("y")) 
            {

                int length = MyConsole.getInt("Enter length: ");
                int width = MyConsole.getInt("Enter width: ");

                double area = (double)length * (double)width;
                double perimeter = ((double)length * 2) + ((double)width * 2);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                choice = MyConsole.getString("Continue? (y/n)");

            }
        }
    }
    class MyConsole
    {
        public static String getString(String prompt) 
        {
            string name ="";
            Console.WriteLine(prompt);
            name = Console.ReadLine();
            return name;
        }

        public static int getInt(String prompt) 
        {
            int i = 0;
            bool success = false;

            while (!success) 
            {
                Console.Write(prompt);
                string s = Console.ReadLine();

                if (int.TryParse(s, out i)) 
                {
                    success = true;
                }
                else 
                {
                    Console.WriteLine("Error - not a whole number: " + s);
                }

            }

            return i;
        }

        public static int getInt(String prompt, int min, int max) 
        {
            int i = 0;
            bool isValid = false;
            while (!isValid) 
            {
                i = getInt(prompt);
                if (i <= min) 
                {
                    Console.WriteLine("Error! Number must be greater than " + min + ".");
                }
                else if (i >= max) 
                {
                    Console.WriteLine("Error! Number must be less than " + max + ".");
                }
                else 
                {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(string prompt) 
        {
            double d = 0;
            bool isValid = false;
            while (!isValid) 
            {
                Console.WriteLine(prompt);
                string s = Console.ReadLine();
                try 
                {
                    d = Convert.ToDouble(s);
                    isValid = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("Error! Invalid number. Try again.");
                }
                
            }
            return d;
        }

        public static double getDoubleInRange(string prompt, double min, double max) 
        {
            double d = 0;
            bool isValid = false;
            while (!isValid) 
            {
                d = getDouble(prompt);
                if (d <= min) 
                {
                    Console.WriteLine(
                            "Error! Number must be greater than or equal to " + min + ".");
                }
                else if (d > max) 
                {
                    Console.WriteLine(
                            "Error! Number must be less than or equal to " + max + ".");
                }
                else 
                {
                    isValid = true;
                }
            }
            return d;
        }

        public static Boolean getBoolean(string prompt) 
        {
            bool b = false;
            bool isValid = false;
            while (!isValid) 
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                try
                {
                    b = Convert.ToBoolean(s);
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Invalid boolean. Try again.");
                }
            }
            return b;
        }
    }
}
