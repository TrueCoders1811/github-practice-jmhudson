using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            string firstName = "";
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = "";
            lastName = Console.ReadLine();
            // Get their favorite number
            int favoriteNumber = 0;
            Console.WriteLine("What is your favorite number?");
            favoriteNumber = int.Parse(Console.ReadLine());
            // Get their favorite animal
            string favoriteAnimal = "";
            Console.WriteLine("What is your favorite animal?");
            favoriteAnimal = Console.ReadLine();




            // Once you have gotten all their info and stored it,
            // display it back to them.
            Console.WriteLine("Your name is " + firstName + " " + lastName);
            // If their favorite number is greater than 10, display it in green. 
            if (favoriteNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (favoriteNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            // If their favorite number is less than 5, display it in red.

            Console.WriteLine("Your favorite number is " + favoriteNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your favorite animal is " + favoriteAnimal);

        }
    }
}
