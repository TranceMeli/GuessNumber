namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max +1);
                response = "";

                while (guess != number)
                {
                    try
                    {
                    Console.WriteLine("Guess a number between: " + min + " and " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " +  guess);

                    
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number)
                    {

                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("no valid input");
                    }

                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win");
                Console.WriteLine("Guesses " + guesses);

                Console.WriteLine("Would you like to play again (Y/N):");
                response = Console.ReadLine().ToUpper();
                

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
        }
    }
}
