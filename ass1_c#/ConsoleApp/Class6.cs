namespace ConsoleApp
{
    public static class Class6
    {
        public static void GuessNumber()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess a random number between 1 and 3: ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is not between 1 and 3");
            }
            else if (guessedNumber == correctNumber)
            {
                Console.WriteLine("You guessed correctly!");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is lower than the random number");
            }
            else
            {
                Console.WriteLine("Your guess is higher than the random number");
            }
        }
    }
}
