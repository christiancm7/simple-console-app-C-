using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init app
            GetAppInfo();

            // Ask users name 
            Console.WriteLine("what is your name?");

            // Get user name input 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            while (true)
            {

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user its not a number
                        Console.WriteLine("Please enter an actual number");

                        // Reset text color
                        Console.ResetColor();

                        //Keep going;
                        continue;
                    }

                    // Cast to int and put in guess 
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Prompt user wrong color
                        Console.WriteLine("Wrong Number, please try again");

                        // Reset text color
                        Console.ResetColor();
                    }
                }

                //Output success message
                // Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Prompt right number
                Console.WriteLine("You are correct!");

                // Reset text color
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play Again [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christian Morales";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset text color
            Console.ResetColor();
        }
        }
}
