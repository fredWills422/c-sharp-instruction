using System;

namespace ch02_2_1_Student_Registration 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Student Registration Form\n");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            int yearOfBirth = GetInt("Enter year of birth: ");
            Console.Write("\n");

            Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is " + firstName + "*" + yearOfBirth);

        }

        private static int GetInt(string prompt) 
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
    }
}
