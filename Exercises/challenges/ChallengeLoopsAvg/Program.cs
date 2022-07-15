namespace ChallengeLoopsAvg
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops - Students average score\n");
            Console.WriteLine(avgScore());
        }

        static decimal avgScore()
        {
            int scoreTotal = 0;
            int scoresNumber = 0;
            decimal scoreAvg = 0;
            int userInput = 0;

            Console.Write("Add a new score, or enter -1 to quit: ");

            while (userInput >= 0 || userInput <= 20)
            {
                try
                {
                    Console.Write("Enter a score mark: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput == -1)
                    {
                        Console.WriteLine("Calculating results.. please wait..\n");
                        Console.Write("The score average is: ");
                        break;
                    }
                    if (userInput < 0 || userInput > 20)
                    {
                        Console.WriteLine("Score should be in range between 0 and 20");
                        continue;
                    }
                    scoreTotal += userInput;
                    scoresNumber++;

                    // Testing code
                    Console.WriteLine("Total score is: " + scoreTotal);
                    Console.WriteLine("Numbers of scores: " + scoresNumber + "\n");
                    scoreAvg = (decimal)scoreTotal / (decimal)scoresNumber;

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

            }

            return scoreAvg;
        }

    }
}