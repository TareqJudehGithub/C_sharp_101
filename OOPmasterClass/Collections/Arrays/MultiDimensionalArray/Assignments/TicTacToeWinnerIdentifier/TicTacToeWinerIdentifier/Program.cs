namespace TicTacToeWinerIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe Winner Identifier\n");

            string[,] TicTacToe =
            {
                {"X", "O", "X" },
                {"O", "X", "O" },
                {"O", "X", "O" }
            };

            Console.WriteLine(Checker(TicTacToe));
            int[] numbers = { 1, 2, 3 };

        }

        static bool Checker(string[,] board)
        {
            // TODO
            bool winner = true;
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    while (board[i, j] == board[i, j])
                    {
                        Console.WriteLine(board[i, j]);
                        if (board[i, j] == board[i, j])
                        {
                            winner = true;
                            break;
                        }

                        else
                        {
                            winner = false;
                            break;
                        }
                    }
                }
            {
            }
            //Console.WriteLine(board[1, 1]);

            Console.Write("Do we have a winner? ");
            return winner;

        }
    }
}